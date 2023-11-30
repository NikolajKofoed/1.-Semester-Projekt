using SejlBåd.Models;

namespace SejlBåd.Services.MemberServices
{
    public class MemberService : IMemberService
    {

        private List<Member> members;
        private JsonFileMemberService JsonFileMemberService { get; set; }

        public MemberService(JsonFileMemberService jsonFileMemberService)
        {
            JsonFileMemberService = jsonFileMemberService;
            members = JsonFileMemberService.GetJsonMembers().ToList();
        }

        Member IMemberService.AddMember(Member member)
        {
            members.Add(member);
            JsonFileMemberService.SaveJsonMembers(members);
            return member;
        }

        void IMemberService.UpdateMember(Member mem)
        {
            if (mem != null)
            {
                foreach(var member in members)
                {
                    if(member.UserId == mem.UserId)
                    {
                        member.Email = mem.Email;
                        member.FirstName = mem.FirstName;
                        member.LastName = mem.LastName;
                        member.PhoneNumber = mem.PhoneNumber;
                        member.UserName = mem.UserName;
                    }
                }
                JsonFileMemberService.SaveJsonMembers(members);
            }
        }

        Member IMemberService.DeleteMember(string memberId)
        {
            if (!string.IsNullOrEmpty(memberId))
            {
                foreach(var member in members)
                {
                    if(member.UserId == memberId)
                    {
                        members.Remove(member);
                        JsonFileMemberService.SaveJsonMembers(members);
                        return member;
                    }
                }
            }
            return null;
        }

        Member IMemberService.GetMember(string memberId)
        {
            if (!string.IsNullOrEmpty(memberId))
            {
                foreach(var member in members)
                {
                    if(member.UserId == memberId)
                    {
                        return member;
                    }
                }
            }
            return null;
        }

        Member IMemberService.Login(string userName, string password)
        {
            if(!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                foreach(var member in members)
                {
                    if(member.Password == password && member.UserName == userName)
                    {
                        return member;
                    }
                }
            }
            return null;
        }
    }
}
