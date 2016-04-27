using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MilesOfSmiles.Models;

namespace MilesOfSmiles.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            BlogViewModel viewModel = new BlogViewModel();
            List<BlogModel> models = new List<BlogModel>();
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2013,12,2),
                    Location = "The Peacock Flaming Grill, Boughton",
                    Details = "Saw the Xmas donkeys giving the reindeers a rest this year so along they came with Father Christmas and had some photos taken with the kids, along with some of our regular stallholders to raise some money for us. Not a lot raised this time but every little helps and we would like to thank everyone that came along to support us.",
                    Show = false
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2013,12,14),
                    Location = "The Bears Paw, Newton",
                    Details = "Stall holders braved the weather to hold a Xmas market at the back of the pub (under the heaters), competition from some popular tv shows and bad weather made for a poor turnout but all the stallholders sold something and all bonded and said what a great atmosphere. A raffle was organised by the pub which is still ongoing so unsure of the amount raised.",
                    Show = true
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014,01,29),
                    Details = "National Citizen Students raised over £300 by holding a car boot sale, a karaoke night, sponsored walk from Ellesmere Port to Chester and a table at a Xmas Fair. The students have now graduated and one lesson  they have learnt is to think of others worse off than yourself! Fantastic bunch of kids who I hope will continue to support Miles of Smiles. They chose the charity after a 'speed dating event' put 6 charities in a room together and we all touted for business off the students. Fab idea and great fun. Thank you boys and girls very much appreciated!",
                    Location = "Chester & Ellesmere Port",
                    Show = true
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2013, 12, 18),
                    Show = false,
                    Details = "John Ferrigno,a 6th form student at Bishops High School aged 16 wore a wacky Christmas suit that he bought for the school's winter ball and then decided to wear it on the last day of term 18th December and put it to good use raising some money. John chose Miles of Smiles due to the link with the charity through teacher Mr Cross who's 2 year old daughter Erin is fighting Leukemia. Over two days with donations from teachers, family and friends John raised £130. Sue Thomas from Miles of Smiles said that these off the cuff ideas are great, especially when young people are involved and we love to hear about them especially when raising money for Miles of Smiles. Erins name is on the list to go on the next trip to go to Disneyland Paris but we still need more money to do the trip so more wacky ideas are very welcome! Thank you to John for thinking of others!"
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 4, 19),
                    Show = true,
                    Details = "An Easter Egg Hunt was held at The Bears Paw  Chester organised by Cat Hibbert the manager.Ticket price was only £5 and include a childrens meal, drink, ice cream and an easter egg. Over 250 easter eggs were donated by Sainsburys and their fantastic customers.",
                    Location = "Bears Paw Chester",
                    Photos = new List<PhotoItem>{ new PhotoItem { TitleText = "Easter Egg Hunt", AltText = "Easter Egg Hunt", ImageSrc = "Bears Paw_2004.JPG" } }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 4, 20),
                    Show = true,
                    Details = "Karaoke was the order of the day at The Catholic Club Brook St Chester who kindly donated the room free of charge to us. Organised by Gary the room was absolutely packed out by a lot of familiar faces including a lot from The Ship along with Joe and Helen Gildea. Ticket price was only £3 and Keith Vincent started off the night and then was in charge of the music for the evening. A massive donation of £500 was made to the charity by Jeff Whittle adding to the other money raised making a total of £920.",
                    Location = "The Catholic Club Brook St Chester"
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 5, 16),
                    Show = true,
                    Details = "Friday 16 May we held what seems to becoming an annual event at Airbus. This years was a 70's night with the fantastic Koocachoo. The dance floor was full all night, some people in fancy dress, fabulous atmosphere and approx £970 made after costs. The evening was so popular we have been asked for an 80's night so that is all now booked and will hopefully be as much of a success as this one was! The disco was hosted by Ange Fairweather who always does a brilliant job for us and will be there for the 80's night. Great supporter of ours Keigh Vincent kicked off the evening by singing some popular 70's songs.",
                    Location = "Airbus Broughton",
                    Photos = new List<PhotoItem> { new PhotoItem { ImageSrc = "AirbusMay2014.JPG", TitleText = "70's night", AltText = "70's night" }}
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 6, 27),
                    Show = true,
                    Details = "The final of The Pub Idol was held at The Bears Paw Chester. What a talented lot of finalists all competing for cash prizes of £250, £150 and £100. Very hard to judge but unanimously voted the winner was 18 year old Alex, followed by Dean and a joint third with Carolynne and Marion. Such a popular event held for the first time at the pub that we are soon going to be agreeing the dates for the 2015 Pub Idol.",
                    Location = "Bears Paw Chester",
                    Photos = new List<PhotoItem> { new PhotoItem { ImageSrc = "fundraising 026.JPG", TitleText = "Pub Idol", AltText = "Pub Idol" }, new PhotoItem { TitleText = "Alex Roddy", AltText = "Alex Roddy", ImageSrc = "pubidolwinner.JPG" } }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 6, 18),
                    Location = "The Mill Hotel",
                    Show = true,
                    Details = "Miles of Smiles treasurer/trustee Gary Horton received a  cheque for £500 from the Chester branch of Unite the Union in June. Gary went along to the Mill Hotel in Chester to pick the cheque up from Mike Laurence, branch secretary. We are very grateful to Chester Unite members for this kind donation.",
                    Photos = new List<PhotoItem> { new PhotoItem { TitleText = "Unite donation", AltText = "Unite donation", ImageSrc = "unite.jpeg" } }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 5, 5),
                    Show = true,
                    Location = "Dutton's Chester",
                    Details = "A Murder Mystery night was held at Duttons in Chester, organised by Caroline Terrington. A meal was included in the £25 ticket price and though only attended by a small number of people managed to raise £245 which was donated through the Just Giving page adding another £61.25. Fab amount once again by Duttons.",
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 6, 18),
                    Show = true,
                    Location = "Ellis Whittam",
                    Details = "Sue met with Anna Jones and the fundraising committee of Ellis Whittam to introduce Miles of Smiles and listen to their fundraising ideas for the next 12 months."
                });
            models.Add(
                new BlogModel
                {
                    Location = "The Hurt Zone",
                    Date = new DateTime(2014, 5, 18),
                    Show = true,
                    Details = "Diane Regester was born and bred in Frodsham but moved to Surrey when she was 19 and still has family and friends living in Frodsham & Helsby. She started boot camp a year ago as she has always liked to keep fit. A group signed up for Hurt Zone which was a 7 mile run across rugged terrain set up by the Army. It involved lots of obstacles along the way including 4 extremely steep hills, cargo nets, mud trenches & other physical training activities. Tough but enjoyable Diane completed the route in 1:35. Diane chose Miles of Smiles in memory of her Father, Keith Millward, who sadly passed away 2 years ago and he did not like to see children suffer. Money from his funeral was also donated to Miles of Smiles. Diane had a Just Giving target of £500 but smashed this with a massive £607.",
                    Photos = new List<PhotoItem> { new PhotoItem { TitleText = "Diane Regester", AltText = "Diane Regester", ImageSrc = "1806.jpeg" } }
                });
            models.Add(
                new BlogModel
                {
                    Location = "Chester",
                    Date = new DateTime(2014, 2, 22),
                    Show = true,
                    Details = "Communit Tea was organised by Chester students completing thier events and management courses. They had to organise an event for charity, chose Miles of Smiles and decided on an Afternoon tea theme. Choosing a venue, acquiring raffle prizes, making cakes and sandwiches and all the advertising were just some of things they had to do. It was a fantastic afternoon and raised nearly £600.",
                    Photos = new List<PhotoItem> { new PhotoItem { TitleText = "Communit Tea", AltText = "Communit Tea", ImageSrc = "Innova 007.JPG" } }
                });
            models.Add(
                new BlogModel
                {
                    Location = "Chester Lakes",
                    Date = new DateTime(2014, 7, 12),
                    Show = true,
                    Details = "Fantastic turnout and the rain held off!!! So pleased to see so many familiar faces! We raised over £500 and though some things did not go to plan it was a superb day in a superb location. Chester Lakes and All About Me Events were the organisers. If things go according to plan this event will be held again next year and be bigger and better!!!",
                    Photos = new List<PhotoItem> { new PhotoItem { TitleText = "Chester Lakes", AltText = "Chester Lakes", ImageSrc = "chesterlakes.JPG" } }
                });
            models.Add(
                new BlogModel
                {
                    Location = "Mercure Abbotswell Hotel",
                    Date = new DateTime(2014, 7,17),
                    Show = true,
                    Details = "Miles of Smiles attended the Mercure Abbotswell Hotel for the Local Hero Awards with Dee 106.3. Miles of Smiles sponsor The Child of Courage Award which was won for the second year running by Anya Bentham. Anya is already on the list to go on the next trip to go to Disneyland Paris as she won last year. Attending the table were 3 representatives for Anya as she is currently receiving treatment in USA, Sue and Phil Thomas, Joanne and Wayne Edwards, Cat the manager of The Bears Paw with her partner Ben and Anna Jones from Ellis Whittam who are currently fundraising for Miles of Smiles. Fabulous evening, great company and terrific food. Miles of Smiles aslo pay for these awards as a thank you to Dee 106.3 for their ongoing support.",
                    Photos = new List<PhotoItem> { new PhotoItem { ImageSrc = "localheroawards.jpg", AltText = "Local Hero Awards", TitleText = "Local Hero Awards"}}
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014,7,21),
                    Show = true,
                    Details = "Iron Man - Steve and Leon completed the Iron Man in Bolton competing with competitors from all over the world.Leon first attempt and Steve's second. Leon could not even swim in January but had to do a 2.4 swim 110 mile cycle and a marathon run 26 miles. Between them raising over £2300 and at this time still counting!",
                    Photos = new List<PhotoItem> 
                    { 
                        new PhotoItem 
                        { 
                            TitleText = "Iron Man", 
                            AltText = "Iron Man", 
                            ImageSrc = "IronMan.jpg" 
                        } 
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014,8,17),
                    Show = true,
                    Details = "Tour de Mon - Dave Richardson and his sister Jane completed the 103 mile cycle race round Angelsey in blustery wet weather. Jane also completed the half marathon on behalf of the charity. A massive £3000 raised by Dave and over £500 by Jane. Jane made a recent announcement she will be doing again next year!!",
                    Photos = new List<PhotoItem> 
                    { 
                        new PhotoItem 
                        { 
                            TitleText = "Tour de Mon", 
                            AltText = "Tour de Mon", 
                            ImageSrc = "TourDeMon.jpg" 
                        } 
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014,8,23),
                    Location = "Bears Paw family fun day",
                    Show = true,
                    Details = "Though attendance was lower than last year and the weather was not brilliant a superb total of £510 was raised. Stallholders, bbq, music and pony rides all raised money for us with the ponies being the biggest hit this year. Alex Roddy the winner of the Bears Paw pub idol also sang for us. Brilliant afternoon.",
                    Photos = new List<PhotoItem> 
                    { 
                        new PhotoItem 
                        { 
                            TitleText = "Bears Paw family fun day", 
                            AltText = "Bears Paw family fun day", 
                            ImageSrc = "FunDay.jpg" 
                        } 
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014,8,24),
                    Show = true,
                    Details = "Karaoke night - Gary looked after and took charge of this event. With opening the night followed by 4 guest singers who all support the charity  . A session of stand up bingo with the prize a £20 voucher from The Bears Paw. A total of over £400 was raised.",
                    Photos = new List<PhotoItem> 
                    { 
                        new PhotoItem 
                        { 
                            TitleText = "Karaoke", 
                            AltText = "Karaoke", 
                            ImageSrc = "karaoke.jpg" 
                        } 
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014,8,30),
                    Show = true,
                    Details = "Kev Houston - Visually impaired from the age of 19 did not stop Kev from wanting to raise some money for the charity for less fortunate children. He decided to do a parachute jump and with the fantastic regulars at the pub contributing over a £1000",
                    Photos = new List<PhotoItem> 
                    { 
                        new PhotoItem 
                        { 
                            TitleText = "Kev - parachute jump", 
                            AltText = "Kev - parachute jump", 
                            ImageSrc = "Kev.jpg" 
                        },
                        new PhotoItem 
                        { 
                            TitleText = "Kev - parachute jump", 
                            AltText = "Kev - parachute jump", 
                            ImageSrc = "Kev2.jpg" 
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014,8,30),
                    Location = "The Oaklands",
                    Show = true,
                    Details = "Country and western theme event was organised by Gary for the charity. Non alcoholic coktails were given to children who attended in fancy dress in the afternoon and alcoholic ones for the adults in the evening. Gunfight competitions also took place with a trophy for the winner in the evening supplied by Olympic Trophies of Hoole, who are great supporters of the charity. A bucking bronco, facepainter and bouncy castle also provided entertainment for the kids. A total of £400 was raised."
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 09, 13),
                    Location = "The Bears Paw",
                    Show = true,
                    Details = "Bears Paw AFC sponsored by Miles of Smiles and Bears Paw, if you would like to go and watch a game please make enquiries with The Bears Paw for the fixture details.",
                    Photos = new List<PhotoItem> 
                    { 
                        new PhotoItem 
                        { 
                            TitleText = "Bears Paw AFC", 
                            AltText = "Bears Paw AFC", 
                            ImageSrc = "BearsPawAFC.jpg" 
                        } 
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 09, 07),
                    Location = "Aintree racing circuit",
                    Show = true,
                    Details = "Miles of Smiles were invited to Aintree racing circuit by Sporting Bears who provide sports cars racing round the track for children with illnesses or disabilities. Sports car owners voluntarily give up their time to give this experience and it has to be said the kids and the adults had a thoroughly enjoyable day.",
                    Photos = new List<PhotoItem> 
                    { 
                        new PhotoItem 
                        { 
                            TitleText = "Sporting Bears", 
                            AltText = "Sporting Bears", 
                            ImageSrc = "sportingbears1.jpg" 
                        },
                        new PhotoItem 
                        { 
                            TitleText = "Sporting Bears", 
                            AltText = "Sporting Bears", 
                            ImageSrc = "sportingbears2.jpg" 
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 9, 25),
                    Location = "The Slow Boat Chester",
                    Show = true,
                    Details = "Ladies evening - A fabulous evening took place at The Slow Boat Chester for the annual Ladies Evening. With some great music provided throughout the meal by Ian Gilbert the night built up to a great game of stand up bingo and the draw for the raffle prizes and on stage the magnificent Pauline Daniels. Pauline was superb and had the ladies laughing away and she was also very taken with the charity and has offered to help out anyway she can for future events. A profit was made of £750 towards the next trip.",
                    Photos = new List<PhotoItem> 
                    { 
                        new PhotoItem 
                        { 
                            TitleText = "Ladies evening", 
                            AltText = "Ladies evening", 
                            ImageSrc = "ladiesevening.jpg" 
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 10, 23),
                    Location = "The Slow Boat Chester",
                    Show = true,
                    Details = "Sportsmans Evening - Another sellout night organised by Gary. The evening as usual had the 10 course banquet stand up bingo and raffle. This year the guest speaker was ex referee Graham Poll along with comedian Paul Boardman, son of Stan. A resounding success with the total raised reaching a massive £3000.",
                    Photos = new List<PhotoItem> 
                    { 
                        new PhotoItem 
                        { 
                            TitleText = "Sportsmans evening", 
                            AltText = "Sportsmans evening", 
                            ImageSrc = "Sportsmans.jpg" 
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 10, 25),
                    Location = "McCleans",
                    Show = true,
                    Details = "Halloween Night - Ceri and family provided a superb Halloween event. Dressing up the new venue for this year at McCleans and making it spooky, along with Glitterbugz and Vicotria cakes it was a great event and the room was packed full of people in fancy dress. Cookie provided the kids entertainment and we had the usual raffle. Nearly £500 was raised.",
                    Photos = new List<PhotoItem> 
                    { 
                        new PhotoItem 
                        { 
                            TitleText = "Halloween", 
                            AltText = "Halloween", 
                            ImageSrc = "Halloween.jpg" 
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 11, 21),
                    Location = "Airbus Broughton",
                    Show = true,
                    Details = "Another fantastic night with loads of people turning up in fancy dress, yes a trend has been started! Over £1500 raised all down to the massive support we received. 80's Gold Band were absolutely superb and along with a marvellous disco provided by Angie Fairweather Pugh we had a full dance floor all evening. Requests for yet another one have been taken on board and an announcement will be made asap.",
                    Photos = new List<PhotoItem>
                    {
                        new PhotoItem 
                        { 
                            TitleText = "80s Night", 
                            AltText = "80s Night", 
                            ImageSrc = "80Night1.jpg" 
                        },
                        new PhotoItem 
                        { 
                            TitleText = "80s Night", 
                            AltText = "80s Night", 
                            ImageSrc = "80Night2.jpg" 
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 11, 30),
                    Location = "McCleans Pentre",
                    Show = true,
                    Details = "What a grotto! Thank you to Rob Biddle and Phil for putting together an amazing new home for Father Xmas. Thanks to Pat and John at the club and Cookie and Mazza the kids entertainers. Thanks as well to Les and Jane doing the photos. Father Xmas and his helper also of course get a very special thank you for taking time out of his busy schedule to pay us a visit. Thank you to those that attended. Another £200 raised.",
                    Photos = new List<PhotoItem>
                    {
                        new PhotoItem 
                        { 
                            TitleText = "Xmas 2014", 
                            AltText = "Xmas 2014", 
                            ImageSrc = "Xmas1.jpg" 
                        },
                        new PhotoItem 
                        { 
                            TitleText = "Xmas 2014", 
                            AltText = "Xmas 2014", 
                            ImageSrc = "Xmas2.jpg" 
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014, 11, 29),
                    Location = "Hawarden Institute of Dance",
                    Show = true,
                    Details = "A total of £1100 was raised at a dance organised by Hawarden Institute of Dance. A fabulous night of dancing along with raffle in Connahs Quay Civic Hall at which the organising group had dressed all the tables and made the room look spectacular. Met some lovely people and even had a bit of a tango!! Marvellous night out.",
                    Photos = new List<PhotoItem>
                    {
                        new PhotoItem
                        {
                            TitleText = "Hawarden Institute of Dance",
                            AltText = "Hawarden Institute of Dance",
                            ImageSrc = "Dance.jpg"
                        }
                    }
                });


            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2014,12,31),
                    Location = "2014",
                    Details = "I would just like to say a final few words for this year from the committee and myself. This year has been a really good year for Miles of Smiles and it has been lovely seeing you at the events during the year. We have had some great events and some fantastic support and have planned and are still planning more events for 2015. We have some new fundraisers coming on board in January and are very pleased that they have chosen Miles of Smiles as their Charity of the Year. North Wales Ramblers Association raised a massive amount of money for their chosen charity in 2014, over £11,000, so we are feeling honoured to have been chosen and look forward to meeting up with them and hopefully joining in at a few of the great things they have planned in their 2015 diary. There a far too many people to thank for raising money for us this year and also all the people who have come along to various dates in our calendar but hopefully you all know who you are and let it be said that you have all made a contribution in one way or another to Miles of Smiles and we would like to thank each and every one of you. I am hoping to make an announcement in March that will put a smile on a few faces! A very Happy New Year to you all from myself and the committee and see you in 2015.",
                    Show = true
                });
            viewModel.Blogs = models;

            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015, 03, 22),
                    Location = "Forum Theatre Chester",
                    Details = "Peachi Events organised by the Chester students doing their events and management course organised a ‘talent Showcase’ which was held at the Forum Theatre in Chester. Groups of children singing and dancing and a couple of adults joined in this lovely afternoon showing off their talent. At the moment we are still waiting for the final total but well over £500 was raised.",
                    Show = true
                });

            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015, 04, 04),
                    Location = "The Bears Paw",
                    Details = "Easter Hunt fun at The Bears Paw. A small amount of children joined in the fun looking for Easter Eggs so that they could claim their prize of a much larger chocolate egg! £50 more in the pot!",
                    Show = true
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015, 04, 10),
                    Location = "Mill Hotel in Chester",
                    Details = "Gary Horton went along to the Mill Hotel in Chester recently to pick up a cheque for £500 from Mike Laurence, Chester Branch Secretary of Unite The Union. This brings the total raised in the last twelve months to £1,000 and Gary was delighted to present a certificate of thanks to Mike on behalf of the charity in recognition of the funds raised by the membership.",
                    Show = true,
                    Photos = new List<PhotoItem>
                    {
                        new PhotoItem
                        {
                            TitleText = "Unite Union",
                            AltText = "Unite Union",
                            ImageSrc = "union_mike.jpg"
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015, 04, 25),
                    Details = "Must also mention that we have Mara who has run her 5 mile a day followed by the Manchester marathon. She is also going to run the Chester half marathon and another marathon later in the year to raise even more money for the charity. We also have Chris Jones who is running in the half marathon. We have new support from Paul D’Ambrogio solicitor/estate agents. Paul is doing an outdoor challenge for us. Lots been going on and still to come so if I have forgotten to mention someone then I apologise!",
                    Show = true
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015,6,27),
                    Details = "Gary, Phil and I went along to do some marshalling for the Funathlon that was organised by the NWCR. Great event and a record 31 teams were entered. The amount of money raised will go towards the final total which will be presented to Miles of Smiles in October.",
                    Show = true
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015,6,25),
                    Details = "Pub Idol - This popular competition kicked off with 8 singers for the first heat. Three very good singers have now gone through to the final, which will be held in September. The Bears Paw are donating the cash prizes of £250, £150 and £100.",
                    Show = true
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015,6,3),
                    Details = "Chris Sweeney has handed over a total of £320 from donations raised towards his running the Chester Half Marathon. Brilliant, well done Chris!",
                    Show = true
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015, 6, 3),
                    Details = "Chester based Chartered Accountants and Business Advisors Pursglove and Brown recently held their annual seven a side charity football tournament at Cheshire County Offices with  several local companies taking part. After a competitive day of football, the company were pleased to announce they had raised an impressive £1,750 for their chosen charity this year which was Miles of Smiles. Trustee and Chair of Miles of Smiles Sue Thomas and fellow trustee Gary Horton went along to Pursglove and Brown headquarters in Castle Street, Chester to pick up a cheque from Daniel Newman, Associate Director.Sue said ''Big thanks to everyone at Pursglove and Brown, especially Daniel for organising the tournament and all the companies that entered teams.",
                    Show = true
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015, 5, 29),
                    Details = "70’s v 80s night - Though low on numbers this evening was its usual resounding success with Kookachoo playing some fabulous 70’s and 80’s music. Attended by some new people as well who had a great night out and will be coming along to our Soul night in November.",
                    Location = "Airbus",
                    Show = true
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015, 6, 26),
                    Details = "Charity Quiz Night. Winners of the new annual quiz organised in conjunction with Miles of Smiles and Chester Lions. A packed room full of knowledge took place for the first time for our new annual event at Cheshire Sports Club with the winners receiving the new Miles of Smiles trophy. Maurice Dutton was the quizmaster and provided some great questions. The trophy was won by The 6 Pack - Brian Goodall, new president of Chester Lions taking part in this winning team.A massive £1,167 was raised of which £500 was included from Chester branch of Unite The Union.",
                    Location = "Cheshire Sports Club",
                    Show = true,
                    Photos = new List<PhotoItem>
                    {
                        new PhotoItem
                        {
                            TitleText = "Quiz Night",
                            AltText = "Quiz Night",
                            ImageSrc = "quiz.jpg"
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015,10,03),
                    Details = "Gary and I were invited to Penyfford British Legion to receive a cheque for a staggering £12,000 from Chris Jones and his wife Trish from North Wales Charity Ramblers who support a different charity each year and Miles of Smiles was the lucky one this year. The money was raised by the members of the NWCR completing various challenges and being sponsored for each one, i. e. 3 peaks and lots of walking challenges, including a Funathlon organised by Steve in the group. Thank you so much for this amazing donation, it really does make such a difference to the charity.",
                    Location = "Penyfford British Legion",
                    Show = true,
                    Photos = new List<PhotoItem>
                    {
                        new PhotoItem
                        {
                            TitleText = "Penyfford British Legion",
                            AltText = "Penyfford British Legion",
                            ImageSrc = "NWCRpresentation.jpg"
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015, 10, 22),
                    Details = "Sportsmans Evening  - raised £2500. Brilliant night with the lovely Lee Sharp (and his smile) and comedian Billy Flywheel. Sold out in The Slow Boat.Fantastic food and service as always.",
                    Location = "Slow Boat Chester",
                    Show = true,
                    Photos = new List<PhotoItem>
                    {
                        new PhotoItem
                        {
                            TitleText = "Sportsmans Evening",
                            AltText = "Sportsmans Evening",
                            ImageSrc = "LeeSharp.jpg"
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015, 12, 02),
                    Details = "Mike Williams a fork lift truck driver from B&Q Chester contacted me to say he wanted to do something for the charity and the only thing he could come up with was walking topless from B & Q Chester to B & Q Queensferry following his shift at work. So wearing just shorts and trainers off he went in the freezing cold weather!!! He raised a total of £327 after one week of collecting. Fantastic and thanks to all those that supported him.",
                    Location = "B&Q",
                    Show = true
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015, 12, 12),
                    Details = "Swansway Peugeot directors donated lots of toys to the charity. Some will be going to the children chosen to go on the trip to Disneyland in May 2016.Some will be given to children who have been on the trip in the past and the rest will be put to good use!",
                    Location = "Swansway Peugeot",
                    Show = true,
                    Photos = new List<PhotoItem>
                    {
                        new PhotoItem
                        {
                            TitleText = "Swansway Peugeot",
                            AltText = "Swansway Peugeot",
                            ImageSrc = "Swansway2.jpg"
                        },
                        new PhotoItem
                        {
                            TitleText = "Swansway Peugeot",
                            AltText = "Swansway Peugeot",
                            ImageSrc = "Swansway3.jpg"
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2015, 11, 20),
                    Details = "Soul Night: Fantastic group Safehouse provided the entertainment along with Ange Fairweather. Usual popular stand up bingo and some great raffle prizes also included. Regular supporters and some new faces. Thank you to all that came along and gave their support.",
                    Location = "Airbus Broughton",
                    Show = true
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2016, 01, 31),
                    Details = "On Sunday 31st January a charity quiz night was held due to special request!! We also had some new faces there and hope they will come along to many more events as they had a great night along with everyone else. Over a £1000 was raised within a matter of a couple of hours.",
                    Show = true,
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2016, 02, 06),
                    Details = "A very popular event was organised by the students under the name of Bibididoo events. ‘A day in the magical kingdom’ was so popular that the event venue had to be changed 3 times due to demand.Lots of various activities were in place to entertain the children along with a visit from Mickey & Minnie and an amount of over £1200 was raised. Well done girls!!",
                    Location = "Chester",
                    Show = true,
                    Photos = new List<PhotoItem>
                    {
                        new PhotoItem
                        {
                            TitleText = "Bibididoo",
                            AltText = "Bibididoo",
                            ImageSrc = "Bibididoo.jpg"
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2016, 03, 01),
                    Details = "In March I received an out of the blue email telling me that we were being given a cheque for £4380!!! CF Fertiliers had been raising money for 14 moths from their vehicles earning a £1 a day which they then donated to 5 charities, all receiving the same amount. To say I was surprised was an understatement!! The charity was chosen as a relative had been on the last trip in 2012. Lillie who is on our posters and had suffered with some very severe medical issues including 40 lots of chemotherapy was the inspiration. Fantastic amount of money!!",
                    Show = true,
                    Photos = new List<PhotoItem>
                    {
                        new PhotoItem
                        {
                            TitleText = "CF Fertiliers",
                            AltText = "CF Fertiliers",
                            ImageSrc = "cf1.jpg"
                        },
                        new PhotoItem
                        {
                            TitleText = "CF Fertiliers",
                            AltText = "CF Fertiliers",
                            ImageSrc = "cf2.jpg"
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2016, 03, 23),
                    Details = "I collected over 90 Easter eggs donated by the fabulous customers from Sainsburys who donate to us every year",
                    Location = "Sainsbury's",
                    Show = true,
                    Photos = new List<PhotoItem>
                    {
                        new PhotoItem
                        {
                            TitleText = "Easter Eggs",
                            AltText = "Easter Eggs",
                            ImageSrc = "EasterEgg2016.jpg"
                        }
                    }
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2016, 03, 29),
                    Details = "Mike (Charlie) Brown had a challenge of cycling 171 miles coast to coast along the Way of The Roses route from Morecambe to Bridlington finishing on 31st March. Mike raised over £450 for us. He did this on his own as well which is a challenge in itself.",
                    Location = "Morecambe to Bridlington",
                    Show = true,
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2016, 04, 10),
                    Details = "Sunday 10th April saw a meeting with everyone going on the Disneyland Paris trip. Pat at McCleans put some food on for us and everyone got an Easter Egg that had been donated by Sainsburys customers and toys were also given out donated by Swansway Peugeot. Everyone got to meet one another and the children were really excited. We also invited a couple of the fundraisers along so that they could see exactly what the money they had donated to the charity actually did!! They were overwhelmed to say the least.",
                    Location = "McCleans",
                    Show = true,
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2016, 04, 10),
                    Details = "Bahareh Ahmadi signed up to some boxing ‘Pink Collar event’ which was held at the Crowne Plaza hotel on Trinity Street at 3pm 10th April, following eight weeks of training.She was raising funds for Miles of Smiles. Bahareh said: I chose Miles of Smiles as I knew this was a charity close to my late father -in-law's heart. Being a mother myself, I could never dream of my daughter becoming ill. Miles of Smiles provides children with a holiday of a lifetime and every little bit helps going towards these trips. She was aiming for £250.",
                    Location = "Crowne Plaza",
                    Show = true,
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2016, 06, 30),
                    Details = "On 30 June Madelaine Taylor and 9 others will be cycling from Chester to Edinburgh. All are hoping to raise a £1000 so times that by 10!!! That will be a great amount if they all reach their target. Watch this space. Madelaine has also organised a fundraising event on 28th May at The Wheatsheaf Parkgate Road to raise some funds towards the cycling trip.",
                    Location = "Chester to Edinburgh",
                    Show = true,
                });
            models.Add(
                new BlogModel
                {
                    Date = new DateTime(2016, 07, 01),
                    Details = "Mara who completed her running challenge last year is at it again!! This is what she says: I am running Chester half marathon,  doing a sky dive,  doing Total Warrior and the Chester full marathon to help raise money for the fantastic Miles of smiles appeal, awesome charity that takes poorly children to Disneyland.. I am paying for all the costs of my challenges so all money raised goes fully to the charity.. Please donate as much as u can afford every penny counts. Mara met some of the kids going on this years trip and cannot do enough for us. We love Mara!!",
                    Location = "Chester",
                    Show = true,
                });
            return View(viewModel);
        }

    }
}
