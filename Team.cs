using System;
using System.Collections.Generic;
using System.Linq;
namespace planHeist
{
    public class Team
    {   
            public List <Member> Members{get;set;}
            public Team()
            {
               Members=new List<Member>();

            }
            public void addMember(Member member)
            {
                Members.Add(member);
            }
            public void showMembers()
            {
                foreach(Member member in Members)
                {
                    Console.WriteLine($"This is {member.Name} thier skill level is {member.SkillLevel} and thier courage factor {member.CourageFactor}");
                }

            }

    public int TotalSkillLevel(){

        return Members.ConvertAll<int>(member=>member.SkillLevel).Sum();
    }

    }

}