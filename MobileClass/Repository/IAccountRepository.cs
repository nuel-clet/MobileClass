using Microsoft.AspNetCore.Identity;
using MobileClass.Models;
using System.Threading.Tasks;

namespace MobileClass.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
        Task SignOut();

    }
}
