using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebAPI.BizLogics;
using System.Collections.Generic;
using DotNetCoreWebAPI.Models;

namespace DotNetCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController: ControllerBase
    {
        private IMemberHandler _memberHandler;
        public MemberController(IMemberHandler memberHandler)
        {
            _memberHandler = memberHandler;
        }

        [HttpGet]
        [Route("/api/member/memberbygender/{gender}")]
        public List<Member> FilterMemberByGender(string gender)
        {
                return _memberHandler.FilterMemberByGender(gender);
        }

        // 2. Return the oldest members
        [HttpGet]
        [Route("/api/member/ReturnTheOldestMember")]
        public Member ReturnTheOldestMember()
        {
            return _memberHandler.ReturnTheOldestMember();
        }

        // 3. Return full name of members
        [HttpGet]
        [Route("/api/member/GetMemberWithFullNameOnly")]
        public List<string> GetMemberWithFullNameOnly()
        {
            return _memberHandler.GetMemberWithFullNameOnly();
        }


        // 4.1 Return list of member who has birth year is 2000
        [HttpGet]
        [Route("/api/member/FilterMemberByBirthYear/{year}")]
        public List<Member> FilterMemberByBirthYear(int year)
        {
            return _memberHandler.FilterMemberByBirthYear(year);
        }

        // 4.2 Return list of member who has birth year less than 2000
        [HttpGet]
        [Route("/api/member/FilterMemberByBirthYearLessThan/{year}")]
        public List<Member> FilterMemberByBirthYearLessThan(int year)
        {
            return _memberHandler.FilterMemberByBirthYearLessThan(year);
        }

        // 4.3 Return list of member who has birth year greather than 2000
        [HttpGet]
        [Route("/api/member/FilterMembersByBirthYearGreater/{year}")]
        public List<Member> FilterMemberByBirthYessLess2000(int year)
        {
            return _memberHandler.FilterMemberByBirthYessLess2000(year);
        }

        // 5. Return the list members who born in HN
        // GET: https://localhost:5001/api/member/FilterFirstMemberWasBornInHaNoi/{place}
        [HttpGet]
        [Route("/api/member/FilterFirstMemberWasBornInHaNoi/{place}")]
        public List<Member> FilterFirstMemberWasBornInHaNoi(string place)
        {
            return _memberHandler.FilterFirstMemberWasBornInHaNoi(place);
        }

        // 7. Add new member to class
        // POST: https://localhost:5001/api/member/
        [HttpPost]
        public List<Member> Post(Member member)
        {
            return _memberHandler.AddNewMember(member);
        }
    }
}