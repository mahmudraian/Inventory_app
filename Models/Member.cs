using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory_app.Models
{
    public class Member
    {
         public string MemberName { get; set; }
        public string MemberRole { get; set; }

        public int MemberId { get; set; }


        public static List<Member> MemberList()
        {
            List<Member> memberList = new List<Member>();

            for (int i = 1; i < 10; i++)
            {
                Member member = new Member();
                member.MemberId = i;
                member.MemberRole = "Users";
                member.MemberName = " User_ "+ i.ToString();
                memberList.Add(member);
            }


            return memberList;
        }



    }
}