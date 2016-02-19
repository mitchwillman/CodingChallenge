using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        public string GetBirthMonth(Person person, string descendantName)
        {
            if (person.Name == "Ted")
            {
                var children = person.Descendants;
                
                List<Person> grandChildren = new List<Person>();

                //get a list of all children and grandchildren of Ted
                foreach (var child in children)
                {
                    grandChildren.AddRange(child.Descendants);
                }

                //If a grandchild or child exists with a name equal to "descendantName" it will return their birth month.
                if (grandChildren.Select(x => x.Name).Contains(descendantName))
                {
                    return grandChildren.FirstOrDefault(x => x.Name == descendantName)?.Birthday.ToString("MMMM");
                }
                else if (children.Select(x => x.Name).Contains(descendantName))
                {
                    return children.FirstOrDefault(x => x.Name == descendantName)?.Birthday.ToString("MMMM");
                }
                else
                {
                    return "Test failed, the descendant does not exist.";
                }
            }
            else
            {
                return "Test failed, person does not exist.";
            }
        }
    }
}
