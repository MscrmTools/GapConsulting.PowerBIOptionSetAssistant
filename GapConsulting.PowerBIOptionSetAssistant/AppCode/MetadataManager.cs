﻿using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.ComponentModel;

namespace GapConsulting.PowerBIOptionSetAssistant.AppCode
{
    internal class MetadataManager
    {
        private readonly IOrganizationService service;

        public MetadataManager(IOrganizationService service)
        {
            this.service = service;
        }

        public void DeleteEntity(string logicalName)
        {
            service.Execute(new DeleteEntityRequest
            {
                LogicalName = logicalName
            });
        }

        public bool EntityExists(string logicalName)
        {
            EntityQueryExpression entityQueryExpression = new EntityQueryExpression()
            {
                // Récupération de l'entité spécifiée
                Criteria = new MetadataFilterExpression
                {
                    Conditions =
                   {
                       new MetadataConditionExpression("LogicalName", MetadataConditionOperator.Equals, logicalName)
                   }
                },
                // Sans propriétés d'entité
                Properties = new MetadataPropertiesExpression
                {
                    AllProperties = false,
                },
            };

            RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
            {
                Query = entityQueryExpression,
                ClientVersionStamp = null
            };

            var response = (RetrieveMetadataChangesResponse)service.Execute(retrieveMetadataChangesRequest);

            return response.EntityMetadata.Count != 0;
        }

        public EntityMetadataCollection GetEntitiesMetadata()
        {
            EntityQueryExpression entityQueryExpression = new EntityQueryExpression()
            {
                // Récupération de l'entité spécifiée
                Criteria = new MetadataFilterExpression
                {
                    Conditions =
                   {
                       new MetadataConditionExpression("IsIntersect", MetadataConditionOperator.Equals, false)
                   }
                },
                // Sans propriétés d'entité
                Properties = new MetadataPropertiesExpression
                {
                    AllProperties = false,
                    PropertyNames = { "Attributes", "DisplayName", "LogicalName", "SchemaName" }
                },
                AttributeQuery = new AttributeQueryExpression
                {
                    // Récupération de l'attribut spécifié
                    Criteria = new MetadataFilterExpression
                    {
                        FilterOperator = LogicalOperator.Or,
                        Conditions =
                       {
                           new MetadataConditionExpression("AttributeTypeName", MetadataConditionOperator.Equals, AttributeTypeDisplayName.MultiSelectPicklistType),
                           new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.Picklist),
                           new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.Boolean),
                           new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.State),
                           new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.Status)
                       }
                    },
                    // Avec uniquement les données d'OptionSet
                    Properties = new MetadataPropertiesExpression
                    {
                        AllProperties = false,
                        PropertyNames = { "OptionSet", "DisplayName", "LogicalName", "EntityLogicalName", "SchemaName" }
                    }
                },
                LabelQuery = new LabelQueryExpression()
            };

            RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
            {
                Query = entityQueryExpression,
                ClientVersionStamp = null
            };

            var response = (RetrieveMetadataChangesResponse)service.Execute(retrieveMetadataChangesRequest);

            return response.EntityMetadata;
        }

        internal void CreatePowerBiOptionSetRefEntity(int lcid, BackgroundWorker bw = null)
        {
            bool entityCreated = false;

            try
            {
                var emd = new EntityMetadata
                {
                    LogicalName = "gap_powerbioptionsetref",
                    SchemaName = "gap_PowerBIOptionsetRef",
                    DisplayName = new Label("Power BI Option-Set Xref", lcid),
                    DisplayCollectionName = new Label("Power BI Option-Set Xrefs", lcid),
                    Description = new Label("Created automatically by Power BI Option-Set Xref XrmToolBox plugin", lcid),
                    OwnershipType = OwnershipTypes.OrganizationOwned,
                };

                var pamd = new StringAttributeMetadata
                {
                    LogicalName = "gap_optionsetschemaname",
                    SchemaName = "gap_OptionsetSchemaName",
                    RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                    MaxLength = 100,
                    FormatName = StringFormatName.Text,
                    DisplayName = new Label("Option Set Schema Name", lcid)
                };

                // Removed for compatiblity with SDK 8.1.0.2
                //service.Execute(new CreateEntityRequest
                //{
                //    Entity = emd,
                //    PrimaryAttribute = pamd,
                //    HasActivities = false,
                //    HasNotes = false,
                //    HasFeedback = false
                //});

                // Added for compatiblity with SDK 8.1.0.2
                service.Execute(new OrganizationRequest("CreateEntity")
                {
                    Parameters =
                    {
                        new System.Collections.Generic.KeyValuePair<string, object>("Entity",emd),
                        new System.Collections.Generic.KeyValuePair<string, object>("PrimaryAttribute",pamd),
                        new System.Collections.Generic.KeyValuePair<string, object>("HasActivities",false),
                        new System.Collections.Generic.KeyValuePair<string, object>("HasNotes",false)
                    }
                });

                entityCreated = true;

                if (bw != null && bw.WorkerReportsProgress)
                {
                    bw.ReportProgress(0, "Creating Entity schema name attribute");
                }

                // Entity schema name
                service.Execute(new CreateAttributeRequest
                {
                    EntityName = emd.LogicalName,
                    Attribute = new StringAttributeMetadata
                    {
                        SchemaName = "gap_EntitySchemaName",
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        MaxLength = 100,
                        FormatName = StringFormatName.Text,
                        DisplayName = new Label("Entity Schema Name", lcid),
                    }
                });

                if (bw != null && bw.WorkerReportsProgress)
                {
                    bw.ReportProgress(0, "Creating Entity name attribute");
                }

                // Entity name
                service.Execute(new CreateAttributeRequest
                {
                    EntityName = emd.LogicalName,
                    Attribute = new StringAttributeMetadata
                    {
                        SchemaName = "gap_EntityName",
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        MaxLength = 100,
                        FormatName = StringFormatName.Text,
                        DisplayName = new Label("Entity Name", lcid),
                    }
                });

                if (bw != null && bw.WorkerReportsProgress)
                {
                    bw.ReportProgress(0, "Creating Language attribute");
                }

                // LCID
                service.Execute(new CreateAttributeRequest
                {
                    EntityName = emd.LogicalName,
                    Attribute = new IntegerAttributeMetadata
                    {
                        SchemaName = "gap_Language",
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        Format = IntegerFormat.Language,
                        DisplayName = new Label("Language", lcid),
                    }
                });

                if (bw != null && bw.WorkerReportsProgress)
                {
                    bw.ReportProgress(0, "Creating Option Value attribute");
                }

                // Value
                service.Execute(new CreateAttributeRequest
                {
                    EntityName = emd.LogicalName,
                    Attribute = new IntegerAttributeMetadata
                    {
                        SchemaName = "gap_Value",
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        Format = IntegerFormat.None,
                        DisplayName = new Label("Option Value", lcid),
                    }
                });

                if (bw != null && bw.WorkerReportsProgress)
                {
                    bw.ReportProgress(0, "Creating Option Label attribute");
                }

                // Label
                service.Execute(new CreateAttributeRequest
                {
                    EntityName = emd.LogicalName,
                    Attribute = new StringAttributeMetadata
                    {
                        SchemaName = "gap_Label",
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        MaxLength = 200,
                        FormatName = StringFormatName.Text,
                        DisplayName = new Label("Option Label", lcid),
                    }
                });

                if (bw != null && bw.WorkerReportsProgress)
                {
                    bw.ReportProgress(0, "Creating Option Image Url attribute");
                }

                // Image Url
                service.Execute(new CreateAttributeRequest
                {
                    EntityName = emd.LogicalName,
                    Attribute = new StringAttributeMetadata
                    {
                        SchemaName = "gap_ImageUrl",
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        MaxLength = 1000,
                        FormatName = StringFormatName.Url,
                        DisplayName = new Label("Option Image Url", lcid),
                    }
                });

                if (bw != null && bw.WorkerReportsProgress)
                {
                    bw.ReportProgress(0, "Publishing entity...");
                }

                service.Execute(new PublishXmlRequest
                {
                    ParameterXml = "<importexportxml><entities><entity>gap_powerbioptionsetref</entity></entities></importexportxml>"
                });
            }
            catch (Exception)
            {
                if (entityCreated)
                {
                    DeleteEntity("gap_powerbioptionsetref");
                }

                throw;
            }
        }
    }
}