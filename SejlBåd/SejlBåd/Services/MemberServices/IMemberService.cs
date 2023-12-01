﻿using SejlBåd.Models;

namespace SejlBåd.Services.MemberServices
{
    public interface IMemberService
    {
        Member LoggedInMember { get;set; }
        Member AddMember(Member member);
        void UpdateMember(Member member);
        Member DeleteMember(string memberId);
        Member GetMember(string memberId);
        Member Login(string userName, string password);
        

    }
}
