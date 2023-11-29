using SejlBåd.Models;

namespace SejlBåd.Services.MemberServices
{
    public interface IMemberService
    {

        Member AddMember(Member member);
        void UpdateMember(Member member);
        Member DeleteMember(string memberId);
        Member GetMember(string memberId);
        bool Login(string userName, string password);
        

    }
}
