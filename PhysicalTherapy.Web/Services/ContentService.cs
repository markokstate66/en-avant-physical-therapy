using PhysicalTherapy.Web.Models;

namespace PhysicalTherapy.Web.Services;

public class ContentService
{
    public List<Service> GetServices()
    {
        return new List<Service>
        {
            new Service
            {
                Id = 1,
                Title = "Developmental Delays",
                Description = "Supporting children who need extra time to reach their developmental milestones with personalized therapy plans.",
                Icon = "bi-heart-pulse",
                LongDescription = "Our developmental delay program provides comprehensive assessment and individualized treatment for children who may be experiencing delays in gross motor, fine motor, or overall physical development. We work closely with families to create supportive home programs.",
                Price = 150,
                DurationMinutes = 45
            },
            new Service
            {
                Id = 2,
                Title = "Gross Motor Skills",
                Description = "Building strength, coordination, and confidence through fun, engaging activities tailored to each child.",
                Icon = "bi-person-arms-up",
                LongDescription = "Our gross motor skills program helps children develop the large muscle movements needed for walking, running, jumping, and playing. Through play-based therapy, we make building strength fun and rewarding.",
                Price = 150,
                DurationMinutes = 45
            },
            new Service
            {
                Id = 3,
                Title = "Balance & Coordination",
                Description = "Helping children develop the balance and coordination they need for everyday activities and play.",
                Icon = "bi-bullseye",
                LongDescription = "Balance and coordination are essential for a child's independence and safety. Our program uses specialized equipment and activities to improve vestibular function, proprioception, and motor planning.",
                Price = 150,
                DurationMinutes = 45
            },
            new Service
            {
                Id = 4,
                Title = "Sports Injury Rehab",
                Description = "Getting young athletes back to the activities they love with age-appropriate rehabilitation programs.",
                Icon = "bi-trophy",
                LongDescription = "Young athletes deserve specialized care that considers their growing bodies. Our sports injury rehabilitation program focuses on safe, effective recovery while preventing future injuries.",
                Price = 175,
                DurationMinutes = 60
            },
            new Service
            {
                Id = 5,
                Title = "Post-Surgery Recovery",
                Description = "Gentle, expert care to help children recover strength and mobility after orthopedic procedures.",
                Icon = "bi-bandaid",
                LongDescription = "After orthopedic surgery, proper rehabilitation is crucial for optimal outcomes. Our experienced therapists provide gentle, age-appropriate post-surgical care in a supportive environment.",
                Price = 175,
                DurationMinutes = 60
            },
            new Service
            {
                Id = 6,
                Title = "Sensory Integration",
                Description = "Supporting children who experience sensory processing challenges with targeted therapeutic interventions.",
                Icon = "bi-stars",
                LongDescription = "Children with sensory processing difficulties may struggle with everyday activities. Our sensory integration therapy helps children learn to process and respond to sensory information more effectively.",
                Price = 160,
                DurationMinutes = 50
            }
        };
    }

    public List<TeamMember> GetTeamMembers()
    {
        return new List<TeamMember>
        {
            new TeamMember
            {
                Id = 1,
                Name = "Dr. Sarah Mitchell",
                Role = "Founder & Lead Physical Therapist",
                Bio = "Dr. Mitchell founded En Avant with a vision to create a warm, welcoming space where every child can thrive. With over 15 years of pediatric experience, she leads our team with compassion and expertise.",
                Credentials = "DPT, PCS",
                Specializations = "Developmental Delays, Neurological Conditions",
                Icon = "bi-person-heart"
            },
            new TeamMember
            {
                Id = 2,
                Name = "Michael Chen",
                Role = "Senior Pediatric PT",
                Bio = "Michael brings 10 years of experience and a genuine love for working with kids. His playful approach and creative therapy games make every session feel like an adventure.",
                Credentials = "PT, CSCS",
                Specializations = "Sports Injuries, Orthopedic Rehab",
                Icon = "bi-person-badge"
            },
            new TeamMember
            {
                Id = 3,
                Name = "Emily Rodriguez",
                Role = "Pediatric Physical Therapist",
                Bio = "Emily specializes in early intervention and loves helping the youngest members of our community build strong foundations for movement and play.",
                Credentials = "DPT",
                Specializations = "Early Intervention, Gross Motor Development",
                Icon = "bi-person-circle"
            },
            new TeamMember
            {
                Id = 4,
                Name = "James Wilson",
                Role = "Physical Therapist Assistant",
                Bio = "James is passionate about making therapy fun! His background in adaptive sports helps him connect with active kids and get them excited about their progress.",
                Credentials = "PTA",
                Specializations = "Balance Training, Adaptive Sports",
                Icon = "bi-person-check"
            }
        };
    }

    public List<Testimonial> GetTestimonials()
    {
        return new List<Testimonial>
        {
            new Testimonial
            {
                Id = 1,
                Quote = "En Avant has been a blessing for our family. Our son went from struggling to walk to running around the playground with his friends. The therapists truly care about every child.",
                Author = "Jennifer M.",
                AuthorTitle = "Parent of 4-year-old",
                Rating = 5,
                ChildAge = "4 years",
                ServiceUsed = "Developmental Delays"
            },
            new Testimonial
            {
                Id = 2,
                Quote = "The En Avant team made my daughter feel so comfortable and confident. She actually looks forward to her therapy sessions! The progress we've seen in just a few months is incredible.",
                Author = "David K.",
                AuthorTitle = "Parent of 6-year-old",
                Rating = 5,
                ChildAge = "6 years",
                ServiceUsed = "Balance & Coordination"
            },
            new Testimonial
            {
                Id = 3,
                Quote = "After my son's soccer injury, I was worried about finding the right rehab for a young athlete. En Avant understood exactly what he needed to get back on the field safely.",
                Author = "Maria S.",
                AuthorTitle = "Parent of 12-year-old",
                Rating = 5,
                ChildAge = "12 years",
                ServiceUsed = "Sports Injury Rehab"
            },
            new Testimonial
            {
                Id = 4,
                Quote = "The early intervention services here gave my baby the best possible start. Dr. Mitchell and her team are knowledgeable, patient, and genuinely invested in each child's success.",
                Author = "Rachel T.",
                AuthorTitle = "Parent of 18-month-old",
                Rating = 5,
                ChildAge = "18 months",
                ServiceUsed = "Gross Motor Skills"
            },
            new Testimonial
            {
                Id = 5,
                Quote = "We drove an hour each way because En Avant is worth it. The sensory integration therapy has made such a difference in our daughter's daily life. She's a different kid!",
                Author = "Tom & Lisa B.",
                AuthorTitle = "Parents of 5-year-old",
                Rating = 5,
                ChildAge = "5 years",
                ServiceUsed = "Sensory Integration"
            }
        };
    }

    public List<BlogPost> GetBlogPosts()
    {
        return new List<BlogPost>
        {
            new BlogPost
            {
                Id = 1,
                Title = "5 Fun Activities to Build Your Child's Balance at Home",
                Excerpt = "Simple, play-based exercises you can do together to help your child develop better balance and coordination.",
                Category = "Home Exercises",
                Icon = "bi-house-heart",
                PublishedDate = DateTime.Now.AddDays(-7),
                Author = "Dr. Sarah Mitchell",
                ReadTimeMinutes = 5
            },
            new BlogPost
            {
                Id = 2,
                Title = "Understanding Developmental Milestones: When to Seek Help",
                Excerpt = "A parent's guide to recognizing when your child might benefit from early intervention services.",
                Category = "Education",
                Icon = "bi-lightbulb",
                PublishedDate = DateTime.Now.AddDays(-14),
                Author = "Emily Rodriguez",
                ReadTimeMinutes = 8
            },
            new BlogPost
            {
                Id = 3,
                Title = "The Benefits of Play-Based Physical Therapy",
                Excerpt = "Why making therapy fun leads to better outcomes and happier kids.",
                Category = "Therapy Tips",
                Icon = "bi-controller",
                PublishedDate = DateTime.Now.AddDays(-21),
                Author = "Michael Chen",
                ReadTimeMinutes = 6
            },
            new BlogPost
            {
                Id = 4,
                Title = "Preparing Your Child for Their First PT Appointment",
                Excerpt = "Tips for parents to help make the first visit positive and stress-free for everyone.",
                Category = "Getting Started",
                Icon = "bi-calendar-check",
                PublishedDate = DateTime.Now.AddDays(-28),
                Author = "Dr. Sarah Mitchell",
                ReadTimeMinutes = 4
            },
            new BlogPost
            {
                Id = 5,
                Title = "Summer Sports Safety: Preventing Injuries in Young Athletes",
                Excerpt = "How to keep your young athletes safe and healthy during sports season.",
                Category = "Prevention",
                Icon = "bi-shield-check",
                PublishedDate = DateTime.Now.AddDays(-35),
                Author = "Michael Chen",
                ReadTimeMinutes = 7
            },
            new BlogPost
            {
                Id = 6,
                Title = "Sensory Processing: Signs Your Child Might Need Support",
                Excerpt = "Common signs of sensory processing challenges and how physical therapy can help.",
                Category = "Education",
                Icon = "bi-eye",
                PublishedDate = DateTime.Now.AddDays(-42),
                Author = "Emily Rodriguez",
                ReadTimeMinutes = 6
            }
        };
    }
}
