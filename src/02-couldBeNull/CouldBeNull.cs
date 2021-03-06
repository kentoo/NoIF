using System;

namespace CouldBeNull
{
    public class CouldBeNull
    {
        public Response getResponse(string id) 
        {
            try
            {
                return new Response
                {
                    message = string.Format("Your id is {0}", Convert.ToInt32(id))
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}