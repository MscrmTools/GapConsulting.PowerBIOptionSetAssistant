using System.ComponentModel.Composition;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace GapConsulting.PowerBIOptionSetAssistant
{
    [Export(typeof(IXrmToolBoxPlugin)),
           ExportMetadata("BackgroundColor", "White"),
           ExportMetadata("PrimaryFontColor", "Black"),
           ExportMetadata("SecondaryFontColor", "Gray"),
           ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxEAAAsRAX9kX5EAAAAHdElNRQfiBhUHLBq+w8Z1AAAAGXRFWHRTb2Z0d2FyZQBwYWludC5uZXQgNC4wLjIx8SBplQAAAXZJREFUWEdjUNIO+D+QePg5QEU38Nv5izdfP3z0/D82PGHKchT1NHBA0Ne3bz+8+I8DLFy6FUX90HNAe8+CZ+cv3XqODW/ZfuQezR2wau3uj1CzMMCjxy/eDW0HeAbkf+ifsuwmNtzaNe+cKjCF09QBlfVTocowwc+fvx5pGoZ+xOaAv3///rh85faNlKyW+3RzwJ8/f37cvPXgdXf/ouemdglvtYzCv3kFFbyhuQNmzFn7ZPb8DY8dPDM+AgudP3Zu6a/nLNjw+P2Hz68fPHxOewcoawf8snRMelvTOP0FqMT79+/fL6gS+qSBCVNWvP7169dXqDAKGLBECAOjDhh1wKgDRh0w6oCh74CCsr4vIIuw4TdvPpzXMAj9RNgBgd8ePHpxBZsZIDxj9tp3yHaiOEBFL/AnyJfYMMhyoJp/hBwAMkfdIOQzNjNAWE0v+DuynSgOIAYT4wBS8NBzgIK6820FNbsT2LH9WWx68GGSHUBdHPAfANr4/p9H1ALuAAAAAElFTkSuQmCC"),
           ExportMetadata("BigImageBase64", "iVBORw0KGgoAAAANSUhEUgAAAFAAAABQCAYAAACOEfKtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAACxEAAAsRAX9kX5EAAAAHdElNRQfiBhUHLBq+w8Z1AAAAGXRFWHRTb2Z0d2FyZQBwYWludC5uZXQgNC4wLjIx8SBplQAAAvtJREFUeF7t1+tLU3EAxvH+Fg0absJcS0i72kUwylktDSzLyAWBUkivZ76oN0JBV0yyLIg2tCu+sJUolZY5K5liGlqZZglrTacnt/Vb7MQhj2Z7vOF5vvAgc+53tg+b4rI4vSXMxT4CgiMgOAKCIyC4JQdoSM7pcda4Bh/UNobR5R8pVb2GcksO0Lw272UoFOoOz0KlpytUr6EcAaeJgGAEBCMgGAHBCAi2qAH15uzA8xftj1+1dbjRnTx1pUE+VzOASSm54+KFfow+V6jqe0/a5XMJGEMEBCMgGAHBCAhGQLBFD9jXN3D9U//QNXRlZ6py5TM1BTgxEYweiVXf2FIkn0nAGJpNQPHYEZ9vxH216r4nPbPQIZ9LwGkSPz86Lkm9re5O5/7D9rIE0x6f8nlGRkCVxM/5xcoP2EqGBNAz5XP7ewSMJu4bFqsrr7zzSGfcPSAeE5Ifq5wpdd+79em2Pvm2pgHF7R+DX7553a+7zqakHfKuMFo/K59HdD/15pyhTGtxk6fzvcPvHx121rha5fs1CRj5evdhw9O8Anunzmj1Kq+t3OqN+e4bt2ojQC6xwO9DRZr8K5yYvHek1d3RcO7i7UpdkvWD+J7qR3Td1oKWwuKyXkmSqoPBYEDghKLH/UmTgHH6zInlhizVd5thVY5/+67jnree7maB0S8mRY9QTaOAk3fQVnLzUkX1VwEQgZvxRbULmGCRNmcc7alzNZeMjY03Rd5pYpM+ov9Kk4AJK7NH2950tYnfa4PiBUMX0CRgLP+JTBUBwQgIRkAwAoIREIyAYAQEIyAYAcEICEZAMAKCERCMgGAEBCMgGAHBCAhGQDACghEQjIBgBAQjIBgBwQgIRkAwAoIREIyAYAQEIyDYogesczUdi7x4dObUvGb5zLkCjE/c6Tt/2WFXu/7/LiOrqF4+d6rNCHAuNleA8z0CgiMgOAKCIyA4AoIjILgFA4w37PiesmZL0Ya0bSfQJZo2XVC7xnxswQCXyggIjoDgCAjNEv4F8Sm7Tj6NpKkAAAAASUVORK5CYII="),
           ExportMetadata("Name", "PowerBI Option-Set Assistant"),
           ExportMetadata("Description", "Creates a custom entity and populates it with records which represent option-set values")]
    public class Plugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new PluginControl();
        }
    }
}