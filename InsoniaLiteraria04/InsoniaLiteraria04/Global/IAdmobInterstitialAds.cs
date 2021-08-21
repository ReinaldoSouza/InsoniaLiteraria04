using System.Threading.Tasks;

namespace InsoniaLiteraria04.Global
{
    public interface IAdmobInterstitialAds
    {
        Task Display(string adId);
    }
}
