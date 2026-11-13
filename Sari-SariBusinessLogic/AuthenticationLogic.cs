using Sari_SariDataLogic;

namespace Sari_SariBusinessLogic
{
    public class AuthenticationLogic
    {
        OwnerDataService ownerDS = new OwnerDataService();
        BantayDataService bantayDS = new BantayDataService();

        public bool IsOwnerCodeCorrect(string userinput)
        {
            return ownerDS.IsOwnerCodeExists(userinput);
        }

        public bool IsBantayCodeCorrect(string userinput)
        {
            return bantayDS.IsBantayCodeExists(userinput);
        }
    }
}
