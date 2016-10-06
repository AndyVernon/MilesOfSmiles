using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MilesOfSmiles.Models;

namespace MilesOfSmiles.Controllers
{
    public class EventsController : Controller
    {
        public ActionResult Index()
        {
            EventViewModel viewModel = new EventViewModel();
            List<EventModel> models = new List<EventModel>();
            models.Add(
                new EventModel 
                { 
                    EventTitle = "Bears Paw Christmas Shopping Evening", 
                    EventDate = new DateTime(2013, 12, 14), 
                    EventDetails = "Christmas shopping event with Mulled wine, Raffle and lots of bespoke gifts for sale." 
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "CommuniT at Northgate Arena ",
                    EventDate = new DateTime(2014, 2, 22),
                    EventDetails = "1 - 4pm. Northgate Church (not arena), close to Fountains roundabout. Tickets £6 in advance or £7 on the door. Children £3 or under 3 free."
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Fabulous 70's night @ Airbus Broughton",
                    EventDetails = "Glam rock band Kookachoo entertains for £10 per ticket plus disco till late. Limited places available at £10 per ticket. Will be a sellout event please contact Gary/Sue for tickets asap. Fabulous evening to put in your diary!",
                    EventDate = new DateTime(2014, 5, 16),
                    //FacebookLink = "<a href='https://www.facebook.com/events/276000029223386/' title='Facebook' runat='server' target='_blank'>See more</a>"
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Family Funday at The Dee Miller",
                    EventDetails = "Family Funday at The Dee Miller",
                    EventDate = new DateTime(2014, 5, 4)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Murder Mystery night @ Duttons Godstall Lane Chester",
                    EventDetails = "£25 inc meal. Stand up bingo and raffle. To book limited available tickets please call Duttons on 01244 401869.",
                    EventDate = new DateTime(2014, 6, 5)
                });

            models.Add(
                new EventModel
                {
                    EventTitle = "Family Funday@ Bears Paw",
                    EventDetails = "12 -4pm   Loads to do, music, BBQ, stalls,raffle",
                    EventDate = new DateTime(2014, 8, 23)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Karaoke night @ Catholic Club Brook St Chester",
                    EventDetails = "Tickets £3. Please contact Gary on 07867887042.",
                    EventDate = new DateTime(2014, 8, 24)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Ladies Evening @ Slow Boat Chester",
                    EventDetails = "Comedienne Pauline Daniels, 10 course chinese banquet, raffle, stand up bingo and disco. Tickets £25, book a table of 10 and pay for only 9. Starts at 7.30pm Contact Sue on 07878221272.",
                    EventDate = new DateTime(2014, 9, 25)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Sportsmans Evening @ Slow Boat Chester",
                    EventDetails = "Guest speaker Graham Pole. 10 course chinese banquet, raffle, stand up bingo. Tickets £30, book a table of 10 and pay for only 9. Contact Gary on 07867887042.",
                    EventDate = new DateTime(2014, 10, 23)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "80's Night @ Airbus Broughton",
                    EventDetails = "7.30pm 80's Gold will be appearing for a solid 80's night. Tickets £10. Contact Sue/Gary. Airbus will provide basket meals if required.",
                    EventDate = new DateTime(2014, 11, 21)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Pub Idol@Bears Paw - Heat 1",
                    EventDate = new DateTime(2014, 03, 29),
                    EventDetails = "Entry fee £5.00, registration by 8:30pm. First prize £250 second prize £150 third prize £100. Winner has to agree to attend and sing at 3 future Miles of Smiles events."
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Pub Idol@Bears Paw - Heat 2",
                    EventDate = new DateTime(2014, 04, 26),
                    EventDetails = "Entry fee £5.00, registration by 8:30pm. First prize £250 second prize £150 third prize £100. Winner has to agree to attend and sing at 3 future Miles of Smiles events."
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Pub Idol@Bears Paw - Heat 3",
                    EventDate = new DateTime(2014, 05, 24),
                    EventDetails = "Entry fee £5.00, registration by 8:30pm. First prize £250 second prize £150 third prize £100. Winner has to agree to attend and sing at 3 future Miles of Smiles events."
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Pub Idol@Bears Paw - The Final",
                    EventDate = new DateTime(2014, 06, 28),
                    EventDetails = "Come along and watch the finalists compete for the prize money, First prize £250 second prize £150 third prize £100. Will be a packed pub and with a late license till 1am make sure you get your seat!"
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Family Fun Day with All About Me Events @ Chester Lakes CH4 9LQ",
                    EventDetails = "All About Me Events CH4 9LQ are holding a Family Fun Day 11am to 4pm. Inc. Bouncy castles, giant tipis, vintage tractors, water alking, gladiator duel, sponge stocks, morris dancing, rodeo bull, hog roast, ice cream, cakes, sweets and a bar and loads more!",
                    EventDate = new DateTime(2014, 7, 12)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Casino night at Duttons",
                    EventDate = new DateTime(2014, 8, 21),
                    EventDetails = "Further details to follow"
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Halloween Party at McCleans Mancot",
                    EventDate = new DateTime(2014, 10, 25),
                    EventDetails = "Halloween Party with disco, prizes for best fancy dress and more, 5pm to 11pm."
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Childrens Xmas Party @ McCleans Mancot",
                    EventDate = new DateTime(2014, 11, 30),
                    EventDetails = "Childrens Xmas Party with disco, visit from Father Xmas and Childrens entertainer. £5 only. Includes seeing Father Xmas.  2pm - 5pm."
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Xmas Indoor Market @ Bears Paw",
                    EventDate = new DateTime(2014, 12, 6),
                    EventDetails = "Xmas Indoor Market - small amount of stalls selling Xmas goods and Glitterbugz tattoos."
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Tour De Mon in Anglesey",
                    EventDate = new DateTime(2014, 8, 17),
                    EventDetails = "David Richardson and his sister Jane Jones are taking part in the gruelling challenge of the Tour De Mon in Anglesey on 17th August. Involving a 103 mile cycle ride  Dave and Jane have had to train very hard to make sure they can complete this event in order to raise funds for Miles of Smiles Chester Appeal. Jane also took part in the Chester half marathon to raise even more money for the local charity. Unite Union have also donated £1000 to Miles of Smiles on behalf of Dave who works at Toyota in Deeside. The cheque was presented to Sue at another event held by Chester Lakes were Dave cycled to adding to his training regime. Sue then presented Dave with a certificate for Unite. Donations can be made via Just Giving checking in on Miles of Smiles."
                });
            models.Add(
                new EventModel 
                {
                    EventTitle = "Black and White Ball @ Hawarden Institute",
                    EventDate = new DateTime(2014, 11, 29),
                    EventDetails = "Black and White Ball organised by Hawarden Institute Dance Club. SOLD OUT."
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Country and western event @ The Oakland Hoole Road Chester",
                    EventDate = new DateTime(2014, 8, 30),
                    EventDetails = "Country and western theme event. Fancy dress competition for both kids and adults. Free 'cocktail' to those in fancy dress. Gunfight for kids and adults, age ranges 4 - 7 year olds, 8 - 12 year olds, 12 - 16 year olds and adults. Bouncy castle, facepainter, BBQ, Cakes and more tbc. 12 - 4 for the kids followed by evening event for adults from 8pm."
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Chester Best amateur talent",
                    EventDetails = "25 Jan 2015 through to May Chester Best amateur talent competition - Registration needs to be by 10th Jan at the latest. £5 per person entry and £2 for family/friends on the door. We are looking for variety acts, not just singers and must be amateur. Heats will take place on various dates throught to the final on May 17th. Please check our FB page for further details.",
                    EventDate = new DateTime(2015, 1, 25)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Chester Lakes - family fun day",
                    EventDetails = "Chester Lakes - family fun day further details TBC.",
                    EventDate = new DateTime(2015, 7, 18)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Karaoke Night",
                    EventDetails = "Starting at 7.30pm at The Catholic Club Brook St Chester another evening of entertainment and karaoke as requested at last years event. Tickets £3 pay on the door.",
                    EventDate = new DateTime(2015, 4, 5)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "70's V 80's Night",
                    EventDate = new DateTime(2015, 5, 29),
                    EventDetails = "By popular demand they are back, Kookachoo/80's Gold starting at 7.30 at Airbus another fabulous night of live music and disco provided by Ange Fairweather Pugh. Tickets £10 each."
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Quiz Night",
                    EventDate = new DateTime(2015, 7, 26),
                    EventDetails = "Cheshire County Sports Club Plas Newton Lane Chester 8pm £5 per person entry minimum 4 to max 6 in a team. Contact Gary for entry 07867 887042."
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Pub Idol",
                    EventDetails = "Starting yet another singing competition being held by our favourite pub the Bears Paw featuring some heats before the final to be held 18th September. Cash prizes to be won. heats are 26 June, 24 July, 21 Aug. £5 entry. Each heat starts at 8.30pm.",
                    EventDate = new DateTime(2015, 6, 26)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Kids fun day",
                    EventDetails = "The Bears Paw holding a childrens fun day 12 - 4pm. Purely for the kids there will be lots to do including childrens crafts, tombola, raffle, pony rides and loads more.",
                    EventDate = new DateTime(2015, 8, 22)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Ladies Night",
                    EventDetails = "By popular demand Pauline Daniels will be making another appearance along with Ian Gilbert to provide some fantastic music. £25 per head, tables of 9 only pay for 10.  A 10 course chinese banquet, raffle and stand up bingo - bargain! Contact Sue for tickets.",
                    EventDate = new DateTime(2015, 9, 24)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Sportsmans Dinner",
                    EventDetails = "Lee Sharp is the guest speaker along with a comedian Billy Flywheel. 10 course chinese banquet, stand up bingo and raffle. Pay only for 9 if you book for 10. Always a sell out night and only £30 per ticket. Contact Gary for tickets.",
                    EventDate = new DateTime(2015, 10, 22)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Halloween",
                    EventDetails = "Following the success of last years Halloween party at McCleans it will again be held at the same venue from 6pm until 10:30pm. Fancy dress is optional. Great music and entertainment. Food and drink available. £3 per person entry.",
                    EventDate = new DateTime(2015, 10, 24)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "The Giant Easter Egg Hunt",
                    EventDetails = "Bears Paw £5 kids meal deal includes a meal, drink, ice cream and Easter egg. Tickets need to be booked with the Bears Paw on 01244 370183.",
                    EventDate = new DateTime(2015, 04, 04)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Soul Night",
                    EventDetails = "To be held at Airbus, Starts at 7.30pm till 12.30am. £10 per ticket. Food available at the bar. Disco. Raffle prizes and stand up bingo.",
                    EventDate = new DateTime(2015, 11, 20)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Karaoke Time",
                    EventDetails = "The Catholic Club Brook St Chester. 7.30pm start £3 on the door.",
                    EventDate = new DateTime(2015, 8, 30)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Charity quiz night",
                    EventDetails = "By popular demand another quiz night (this one for fun, not the trophy) £5 per person entry fee. Teams a minimum of 4 and maximum of 6. Contact Gary or Sue for entry.",
                    EventDate = new DateTime(2016, 01, 31)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "A Day in the Magical Kingdom",
                    EventDetails = "Bibbidoo Events present A Day in the Magical Kingdom. £4 per ticket or pay on the door. Loads to do for the kids plus tombola for the adults.",
                    EventDate = new DateTime(2016, 02, 06)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Through the Decades",
                    EventDetails = "£10 per ticket - The Mix Party Band kicks off the Xmas party season with Through the Decades music to entertain you along with our great DJ Ange Fairweather plus the usual stand up bingo and raffle, need to book asap",
                    EventDate = new DateTime(2016, 11, 26)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Karaoke Night",
                    EventDetails = ": Karaoke Night is back at The Catholic Club 7.30pm start with guests singers followed by open to all karaoke. £3 ticket or pay on the door.",
                    EventDate = new DateTime(2016, 5, 1)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Charity Quiz",
                    EventDetails = "Annual Charity Quiz to be held at Cheshire County Sports Club 8pm. Teams, minimum of 4, maximum of 6. £5 pp entry fee. Please contact Gary or Sue to register.",
                    EventDate = new DateTime (2016, 7, 17)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Chester Lakes",
                    EventDetails = "Details in hand at the moment. Will be released asap.",
                    EventDate = new DateTime(2016, 08, 20)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Sportsmans Evening",
                    EventDetails = "We are delighted to welcome our guest speaker for this year, ex Newcastle United, Coventry City striker and Talk Sport Presenter Micky Quinn. Also played for Wigan, Stockport, Oldham and Portsmouth. Also very pleased to welcome back by popular demand our Comedian Gary Skyner, who is quite simply hilarious. £30 per head, tables of 10 for the price of 9.Full Chinese banquet, raffle and stand up bingo. 7 pm. for 7.15 pm PROMPT start.Dress code is lounge suits / or smart(no jeans or t shirts).",
                    EventDate = new DateTime(2016, 10, 20)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Halloween Party",
                    EventDetails = "Fancy dress competitions for both adults & kids. Entertainment. Food. Glitterbugz. More TBA. McCleans Pentre. 6pm – 10.30pm.",
                    EventDate = new DateTime(2016, 10, 22)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Kids Xmas Party",
                    EventDetails = "Further details will be released.",
                    EventDate = new DateTime(2016, 12, 04)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Kids Charity 25th Birthday Party ",
                    EventDetails = "In aid of Miles of Smiles 25th birthday. 2pm to 5pm. Disco & entertainment. TBA.",
                    EventDate = new DateTime(2017, 04, 27)
                });
            models.Add(
                new EventModel
                {
                    EventTitle = "Gala Charity Night",
                    EventDetails = "£50 per ticket - Special night for Miles of Smiles 25th birthday. 7pm for 7.30 start – 1am. Crowne Plaza Chester. Further details TBA.",
                    EventDate = new DateTime(2017, 05, 20)
                });
            viewModel.AllEvents = models;
            return View(viewModel);
        }
    }
}
