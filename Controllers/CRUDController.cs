using ClassWork.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ClassWork.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]

    public class CRUDController : ControllerBase
    {
        [HttpGet]
        
        [Route("/GetName1")]

        public IEnumerable<GetResponse> GetName()
        {
            GetResponse response = new GetResponse();
            response.Age = 40;
            response.Name = "Afrodite";
            List<GetResponse> responses= new List<GetResponse>();
            responses.Add(response);
            return responses;
        }

        //-----------------------------------------------------------------------------//
        [HttpPost(Name="PostName")]

        public IEnumerable<PostResponse> PostName(PostRequest post) 
        {
            PostResponse postResponse = new PostResponse();
            List<PostResponse> responses = new List<PostResponse>();

            if (post.CheckPeople==1)
            {
                postResponse.Age = 55;
                postResponse.Gender = "KnikMard";
                postResponse.Name = "Vardanush";
            }
            else
            {
                postResponse.Age = 66;
                postResponse.Gender = "txaMard";
                postResponse.Name = "Varda";

            }
            responses.Add(postResponse);
            return responses;
        }
        //------------------------------------------------------------------------------//
        [HttpGet]
        [Route("/NewGet")]
        public IEnumerable<NewGetResponse> NewGet()
        {
            NewGetResponse rs = new NewGetResponse();
            rs.Year = 2022;
            rs.Number = 1;
            rs.Money = 746489;
            List<NewGetResponse> newGetResponses = new List<NewGetResponse>();
            newGetResponses.Add(rs);

            return newGetResponses;
        }



        //----------------------------------------------------------------------------//
        [HttpPost]
        [Route("/NewPost")]

        public IEnumerable<NewResponse> NewPost(NewRequest postes)
        {
            NewResponse newResponse = new NewResponse();
            List<NewResponse> nresponses = new List<NewResponse>();

            if (postes.CountryNames == "Yerevan")
            {
                newResponse.Area = 2500000;
                newResponse.Lake = "Sevan";
            }
            else
            {
                newResponse.Area = 0000000;
                newResponse.Lake = "Chem Gida";
            }
            nresponses.Add(newResponse);
            return nresponses;
        }

    }
}
