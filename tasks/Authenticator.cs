using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace exercism.tasks
{
    public class Authenticator
    {
        private readonly Identity admin;

        private readonly Dictionary<string, Identity> developers =
            new Dictionary<string, Identity>
            {
                ["Bertrand"] = new Identity { Email = "bert@ex.ism", EyeColor = EyeColor.Blue },
                ["Anders"] = new Identity { Email = "anders@ex.ism", EyeColor = EyeColor.Brown }
            };

        public Authenticator(Identity admin)
        {
            this.admin = admin;
        }

        public Identity Admin => admin;

        public IDictionary<string, Identity> GetDevelopers()=>  new ReadOnlyDictionary<string, Identity>(developers);
    }

    public class Identity
    {
        public string Email { get; set; }
        public EyeColor EyeColor { get; set; }
    }

    public enum EyeColor
    {
        Blue,
        Green,
        Brown,
        Hazel,
        Grey
    }
}
