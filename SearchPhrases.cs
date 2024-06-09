using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BingRewardsAutoSearcher
{
    internal static class SearchPhrases
    {

        static readonly string[] searchPhrases = {
            "Best pizza near me",
            "How to lose weight",
            "Weather tomorrow",
            "Popular baby names",
            "Latest movie releases",
            "Easy dinner recipes",
            "Yoga for beginners",
            "Famous landmarks in Paris",
            "Top travel destinations",
            "Best smartphone 2024",
            "Home workout routines",
            "Dog-friendly parks",
            "How to bake cookies",
            "Cheap flight deals",
            "DIY home projects",
            "Benefits of meditation",
            "Coffee shops nearby",
            "Local news updates",
            "Hiking trails near me",
            "Concerts in my area",
            "Best sushi restaurants",
            "History of the internet",
            "Symptoms of flu",
            "Best running shoes",
            "Vegan dessert recipes",
            "How to save money",
            "Top tech gadgets",
            "Cleaning tips and tricks",
            "Famous paintings",
            "Latest fashion trends",
            "Car maintenance tips",
            "Best books to read",
            "Digital marketing tips",
            "How to play guitar",
            "Weekend getaway ideas",
            "Top TV shows",
            "Healthy snack ideas",
            "Financial planning advice",
            "Gardening tips for beginners",
            "Best laptop deals",
            "How to write a resume",
            "Photography tips",
            "Online learning platforms",
            "Popular podcasts",
            "Wedding planning checklist",
            "Sustainable living ideas",
            "How to improve memory",
            "Camping gear essentials",
            "Best video games",
            "New restaurant openings",
            "Best hiking gear",
            "Gluten-free recipes",
            "How to start a blog",
            "Local art galleries",
            "Best credit cards",
            "How to make sushi",
            "Electric cars 2024",
            "Parenting tips",
            "Best skincare products",
            "How to learn Spanish",
            "Popular Netflix shows",
            "Best budget laptops",
            "Home office ideas",
            "How to meditate",
            "Pet adoption near me",
            "Best investment apps",
            "How to write a cover letter",
            "Local farmer's markets",
            "How to brew beer",
            "Best beaches in Florida",
            "How to reduce stress",
            "Interior design trends",
            "Best podcasts 2024",
            "How to knit a scarf",
            "Road trip planner",
            "Best wine under 20",
            "Freelance job websites",
            "How to play chess",
            "Car rental deals",
            "How to make pancakes",
            "Best online courses",
            "Local theater shows",
            "Best places to retire",
            "How to compost",
            "Eco-friendly products",
            "How to draw a cat",
            "Best headphones 2024",
            "Famous quotes",
            "Best ice cream shops",
            "How to start a garden",
            "Best cities to visit",
            "How to brew coffee",
            "Local fitness classes",
            "Best hiking trails",
            "How to write a novel",
            "Local food festivals",
            "How to make a smoothie",
            "Best places to camp",
            "How to do yoga",
            "How to change a tire",
            "Best programming languages 2024",
            "How to learn Python",
            "Top JavaScript frameworks",
            "Best IDE for coding",
            "Agile development methodologies",
            "Cloud computing services",
            "Machine learning tutorials",
            "How to build a website",
            "Data science courses",
            "Blockchain technology explained",
            "Best coding bootcamps",
            "How to use Git",
            "Mobile app development",
            "Artificial intelligence projects",
            "Best databases for web development",
            "Cybersecurity tips",
            "DevOps practices",
            "Front-end vs back-end",
            "How to create a REST API",
            "Docker container tutorial",
            "Best text editors for coding",
            "How to use Kubernetes",
            "Full stack development",
            "Best software testing tools",
            "How to use TensorFlow",
            "Microservices architecture",
            "Top tech blogs",
            "Big data analytics",
            "How to use AWS",
            "Best coding resources",
            "Web development frameworks",
            "Internet of Things projects",
            "How to learn Java",
            "Software development lifecycle",
            "Best tech podcasts",
            "Continuous integration tools",
            "How to use React",
            "Artificial intelligence ethics",
            "How to use Django",
            "Best coding practices",
            "Robotic process automation",
            "How to learn SQL",
            "Best tools for remote work",
            "Cloud storage solutions",
            "How to learn C++",
            "Best open source projects",
            "How to use Node.js",
            "Blockchain development platforms",
            "How to learn Swift",
            "Best Linux distributions"
        };

        internal static string[] Get(int numPhrases = 0)
        {
            // Return all phrases if 0. Otherwise, return the number requested.
            if (numPhrases == 0 ) { return searchPhrases; }
        
            return searchPhrases.Take(numPhrases).ToArray();
        
        }

        internal static string[] GetRandom(int numPhrases = 0)
        {
            // Clone the list of search phrases and then shuffle them.
            var randomPhrases = (string[])searchPhrases.Clone();

            RandomNumberGenerator.Create();
            RandomNumberGenerator.Shuffle<string>(randomPhrases);

            // Return all phrases if 0. Otherwise, return the number requested.
            if (numPhrases == 0 ) { return randomPhrases; }

            return randomPhrases.Take(numPhrases).ToArray();
        }
    }
}
