using System.Collections.Generic;
using DotNetCoreWebAPI.Models;

namespace DotNetCoreWebAPI.BizLogics
{
    public interface IMemberHandler
    {
        //1.Return a list of members who is Male

            List<Member> FilterMemberByGender(string gender);
        //2.Return the oldest one

        Member ReturnTheOldestMember();
        //3.Return full name of members
        List<string> GetMemberWithFullNameOnly();
        //4.1 Return list of members who has birth year is 2000
        List<Member> FilterMemberByBirthYear(int year);
        //4.2 Return list of members who has birth year greater than 2000
        List<Member> FilterMemberByBirthYearLessThan(int year);
        //4.3 Return list of members who has birth year less than 2000
        List<Member> FilterMemberByBirthYessLess2000(int year);
        //5. Return the first person who was born in Ha Noi.
        List<Member> FilterFirstMemberWasBornInHaNoi(string place);

        // CRUD
        // Create(Insert) Member
        List<Member> AddNewMember(Member member);
        void InsertMember(Member emp);
        // Read Member
        List<Member> SelectAllMembers();
        Member SelectMemberById(int id);
        // Update Member
        void UpdateMember(Member emp);
        // Delete Member
        void DeleteMember(int id);
    }
}