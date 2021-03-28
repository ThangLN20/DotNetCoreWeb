using System;
using System.Collections.Generic;
using System.Linq;
using DotNetCoreWebAPI.Models;

namespace DotNetCoreWebAPI.BizLogics
{
    public class MemberHanlder : IMemberHandler
    {
        public MemberHanlder()
        {
            SeedingData();
        }
       public List<Member> FilterMemberByGender(string gender)
        {
            var result = _listMembers.Where(x => x.Gender == gender).ToList();

            return result;
        }

        // 2. Return the oldest members
        public Member ReturnTheOldestMember()
        {
            var minDob = _listMembers.Min(x=>x.DateOfBirth);
            var result = _listMembers.FirstOrDefault(x => x.DateOfBirth == minDob);
            return result;
        }

        // 3. Return full name of members
        public List<string> GetMemberWithFullNameOnly()
        {
            var result  = _listMembers.Select(x => $"{x.FirstName + x.LastName}").ToList();

            return result;  
        }

        // 4.1 Return list of member who has birth year is 2000
        public List<Member> FilterMemberByBirthYear(int year)
        {
            var result = _listMembers.Where(x => x.DateOfBirth.Year == year).ToList();

            return result;
        }

        // 4.2 Return list of member who has birth year less than 2000
        public List<Member> FilterMemberByBirthYearLessThan(int year)
        {
            var result = _listMembers.Where(x => x.DateOfBirth.Year < year).ToList();

            return result;
        }

        // 4.3 Return list of member who has birth year greather than 2000
        public List<Member> FilterMemberByBirthYessLess2000(int year)
        {
            var result = _listMembers.Where(x => x.DateOfBirth.Year > year).ToList();

            return result;
        }

        // 5. Return the list members who born in HN
        public List<Member> FilterFirstMemberWasBornInHaNoi(string place)
        {
            var result = _listMembers.Where(x=>x.BirthPlace == place).ToList();

            return result;
        }        
        private List<Member> _listMembers;
        private void SeedingData()
        {
            _listMembers = new List<Member>
            {
                 new Member
                {
                    
                    FirstName = "Thanh",
                    LastName = "Le",
                    BirthPlace = "Ha Noi",
                    DateOfBirth = DateTime.Now.AddYears(-30),
                    Gender = "Male",
                    IsGrate = true,
                    PhoneNumber = "0123456789",
                    StratDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
                 new Member
                {
                    
                    FirstName = "Tung",
                    LastName = "Vu",
                    BirthPlace = "Bac Ninh",
                    DateOfBirth = DateTime.Now.AddYears(-24),
                    Gender = "Male",
                    IsGrate = true,
                    PhoneNumber = "0123456789",
                    StratDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
                  new Member
                {
                    
                    FirstName = "Thao",
                    LastName = "Vu",
                    BirthPlace = "Ha Noi",
                    DateOfBirth = DateTime.Now.AddYears(-26),
                    Gender = "Female",
                    IsGrate = true,
                    PhoneNumber = "0123456789",
                    StratDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
                   new Member
                {
                  
                    FirstName = "Thang",
                    LastName = "NGuyen",
                    BirthPlace = "Da Nang",
                    DateOfBirth = DateTime.Now.AddYears(-15),
                    Gender = "Male",
                    IsGrate = true,
                    PhoneNumber = "0123456789",
                    StratDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
                    new Member
                {
                   
                    FirstName = "Phuong",
                    LastName = "Nguyen",
                    BirthPlace = "Ha Noi",
                    DateOfBirth = DateTime.Now.AddYears(-20),
                    Gender = "Female",
                    IsGrate = true,
                    PhoneNumber = "0123456789",
                    StratDate = DateTime.Now.AddYears(-10),
                    EndDate = DateTime.Now.AddYears(5)
                },
            };
            }

         // CRUD
        // Create(Insert) Member
         public List<Member> AddNewMember(Member member)
        {
            _listMembers.Add(member);
            return _listMembers;
        }
        public void InsertMember(Member member)
        {
            _listMembers.Add(member);
        }

        // Read Member
        public List<Member> SelectAllMembers()
        {
            return _listMembers;
        }

        public Member SelectMemberById(int id)
        {
            return _listMembers.Find(x=>x.Id == id);
        }

        // Update Member
        public void UpdateMember(Member member)
        {
            Member memberUpdate = _listMembers.Find(x => x.Id == member.Id);
            memberUpdate.FirstName = member.FirstName;
            memberUpdate.LastName = member.LastName;
            memberUpdate.Gender = member.Gender;
            memberUpdate.DateOfBirth = member.DateOfBirth;
        }

        // Delete Member
        public void DeleteMember(int id)
        {
            Member memberDelete = _listMembers.Find(x => x.Id == id);
            _listMembers.Remove(memberDelete);
        }
    }
}    