using System.ComponentModel;

namespace AspNetExampleDomain.Enums
{
    public enum Gender
    {
        [Description("Мужской пол")]
        Male = 0,

        [Description("Женский пол")]
        Female
    }
}
