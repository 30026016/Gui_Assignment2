using System;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Assignment.ViewModels
{
    public class NewsViewModel
    {
        private static Random s_random = new Random();
        private string _headline;
        private Uri _imageUri;

        public string Headline
        {
            get { return _headline; }
            set { _headline = value; }
        }

        public ImageSource ImageSource
        {
            get { return new BitmapImage(_imageUri); }
        }

        public string FullText
        {
            get
            {
                if (Headline == "Covid-19")
                {
                    return @"A man treated as a contact of two women who tested positive for Covid-19 after he flew to a Christchurch isolation facility says he should’ve been tested earlier. Cayden Wilson, from Balclutha, Otago, moved to Australia about three months ago but was unable to find work and arrived back in the country on June 9. He was immediately put into managed isolation – for people with no symptoms – for what was to be 14 days at the isolation facility at Novotel Ellerslie in Auckland.

Wilson, who originally was unaware the facility was also hosting people from other flights at various stages of quarantine, told Stuff he expected to be tested for Covid-19 on day one. On June 13 he received a letter from quarantine officials which said a new facility had been opened in Christchurch as part of the wider managed isolation and quarantine programme. The invitation, which included free flights to Christchurch, said he could spend the rest of his time in managed isolation “closer to your home”. Wilson, who did not have any flights booked, jumped at the opportunity. He and about 100 others took two bus trips as part of the journey as well as the flight. All passengers wore masks and followed social distancing requirements.

On Wednesday Wilson, who at that stage had not been tested for coronavirus, saw the news that two women, who left the facility before their mandatory 14-day period had tested positive for Covid-19. “I rang the nurses because I’d seen it all over the media, and I was like 'can I just get tested please for peace of mind' and then originally they were like 'no, you get tested on the 12th day'.” The Ministry of Health’s contact tracing team called later in the day to say he was classified as a contact and needed to be tested “straight away”. He was still waiting for his results on Thursday evening. “I was sort of prepared for it, but it was still shocking,” the 20-year-old said. “It’s pretty surreal really. It’s a situation I never thought I’d be in really.”";
                }
                else if (Headline == "Trans-Tasman Air Start")
                {
                    return @"Anyone flying between Australia and New Zealand must now wear a facemask to stop the spread of the coronavirus. Director-general of health Dr Ashley Bloomfield, at a press conference on Thursday, said there's 'still a pandemic raging' outside of New Zealand, and extra precautions are needed. The new rules for passengers come after three new cases of Covid-19 surfaced this week, all from overseas, breaking a 24 day streak of zero cases. 'Incoming travellers posed the greatest threat to our elimination goal,' pathology doctor from Dunedin Dr Ling Chan said.

An airplane cabin space was 'a perfect way to spread the virus', Chan said. 'Everyone wearing a mask in an enclosed space protects everyone else, reducing the chances of transmission significantly.' Nearly all 'super clusters' came from an enclosed, indoor environment, where many people come into contact with each other over prolonged periods of time, she said.

Figures show since lockdown started, 64,000 people have come into New Zealand, and the Government has said it expects more people arriving at New Zealand's border to test positive. Mandatory mask use on all flights would be more effective than simply handwashing and covering sneezes, Chan said. 'Covid - 19 is highly infectious and spread mainly by speech droplets.'";
                }
                else if (Headline == "New Features For Working People")
                {
                    return @"Dropbox has added new tools and features to the platform designed to aid in working from home setups and improve productivity. Dropbox Plus features include Dropbox Passwords, Dropbox Vault and computer backup. Dropbox Passwords is the result of Dropbox’s acquisition of Valt last year and allows users to log in to websites and apps by storing passwords and syncing them across devices. This requires no additional knowledge of encryption. Dropbox Vault secures and organises users’ most important documents and allows them to grant emergency access to select friends or family, so only known people can access the files when needed.

Vault offers an additional layer of security, including a 6-digit PIN, on top of Dropbox’s existing security features, the company states. Computer backup automatically backs up users’ Mac or PC folders to Dropbox for secure access on the go and retrieval even when hardware fails or is lost. The features are available in beta to new Dropbox Plus users on mobile, and will become available to all existing Dropbox Plus users in the coming weeks, the company states. Computer backup is also available to Dropbox Basic and Professional users now.

Dropbox also announced plans to introduce Dropbox Family, a new plan for up to six members with individual account views and logins with unified billing. The plan will allow users to create a shared Family space to make family photos and important family documents available to all members. Each individual member will also have space to privately store their files, in addition to all Dropbox Plus features. Dropbox Family will become available to Dropbox Plus users in the next few weeks, and to all later this year. In addition to the above, Dropbox also unveiled new features and workflows to better support distributed teams. This includes HelloSign eSignature embedded as a native feature within Dropbox, bringing the joint value proposition of HelloSign and Dropbox to users.
";
                }
                else if (Headline == "McLaren Pays Tribute")
                {
                    return @"Roof scoops on supercars are objectively cool, and for some reason, they're nowhere to be seen in this day and age. That was until McLaren revealed a special new 720S. Celebrating the success that the iconic F1 GTR had at Le Mans back in 1995, this 720S Le Mans Special Edition wears a similar livery, rocks similar wheels, but most importantly, features a roof scoop. 

Like every special edition McLaren, this Le Mans special will be built in extremely limited numbers, with just 50 set for production. 16 of those have been already confirmed for Europe. Customers will be able to choose between two exterior finishes including McLaren Orange or Sarthe Grey. On the inside, the Alcantara-covered cabin will have either orange or grey accents based on the exterior colour choice. To match the original GTR, these special 720S models feature lower front and rear bumpers, as well as lowered side skirts. The livery sweeps across these skirts to the grey rear bumper, and features a “McLaren 25 anniversary Le Mans” logo.

Adding to these unique features is the set of five-spoke LM wheels, the fully-functional roof scoop, gold-coloured callipers, and carbon fibre louvered front fenders. A set of carbon fibre racing seats can be found inside, as well as a VIN starting with 298, as a nod to the number of laps completed in 1995. Surprisingly, the 720S' powertrain has remained unchanged here, with the twin-turbo 4.0-litre V8 pumping out 530kW and 770Nm of torque. This is enough to propel the supercar to 100km/h in just 2.9 seconds before topping out at 341km/h. Orders are open for this 720S Le Mans, with pricing starting from $500,000 over in the UK. Deliveries are set to start in September.";
                }
                else if (Headline == "PS5 Reveal Event")
                {
                    return @"Sony's big PlayStation 5 games reveal event, titled The Future of Gaming, revealed a ton of upcoming PS5 games, new and current-gen. You can watch the entire thing right here and learn about every single PS5 game shown during the reveal. We also got our very first look at the PS5 console itself. It's a bizarre-looking system but the most important thing about it is that it is going to have a ton of software support and a variety of genres to choose from. You can rewatch Sony's The Future of Gaming event on PlayStation's YouTube and Twitch. For more on what to expect from Sony's upcoming console, check out everything we know about the PS5 so far.

Rockstar's massively successful Grand Theft Auto 5 is coming to the PS5. The new version will feature enhancements and will be expanded, and it's coming in 2021, with GTA Online free to all PS5 owners. Spider-Man: Miles Morales was shown during the event. Miles Morales takes over as the playable character this time around. The game seems to include more science-fiction elements. It will release during the holiday season. Rather than be a complete sequel, however, it's actually an enhanced and expanded version of 2018's game. A new Gran Turismo is in the works for PS5, and it features a campaign mode. Developed with Polyphony Digital, the racing simulator looks incredibly realistic, both in its vehicles and its environments.

A new Ratchet & Clank game is in development, and it looks like the heroes have found themselves in a universe with collapsing dimensions, futuristic cities, and dinosaurs. The demonstration featured gameplay, and it included a rain grinding section and even flight on an alien creature. Square Enix and Luminous Productions premiered a game called Project Athia, which featured werewolf-like creatures and flying sections. It will come exclusively to PS5. Annapurna Interactive revealed a robot-focused game called Stray set in a world where humans have died off. Cats, however, are still in abundance, and the robots appear to be replacing humanity in their old roles. It sports a neon-infused aesthetic, and the adorable kitties wear backpacks. It's coming in 2021.
";
                }
                else if (Headline == "Microsoft Surface Go 2 First Impressions")
                {
                    return @"Microsoft’s Surface Go line seemed to be an answer in search of a question when the company first unveiled it, actually, many questions. Among some of the questions, people might have had when weighing the options between a relatively pocketable mini Surface or its bigger well known Pro brother is, why? Over the next few weeks, I’ll see if this little device can answer that question. On paper, the Surface Go is only a shadow of the Pro with a less powerful processor, smaller screen, smaller keyboard attachment, and handcuffed with Windows 10 S out of the box, but hell if it isn’t a well-crafted piece of hardware that warrants a double-take when looking at future PC purchases.

The Surface Go 2 comes with the same meticulously and almost child-proof packaging as any other Surface device, but when you finally claw the device out of its outer sarcophagus, you’re met with the relatively lightweight PC, long-held proprietary charging cable and seemingly unnecessary paperwork. For those fortunate enough to afford the attaching keyboard, there is some extra packaging to go through, but you won’t cut yourself or lose part of a fingernail in the process. Together, the attached Microsoft Signature keyboard and Surface Go 2 feel about a heavy as Moleskin notebook (give or take a few ounces), and because of the size, I found myself toting it back and forth between rooms similar to my paper and pen notebook. Unfortunately, the review unit I received didn’t include the majestic Surface Pen, so a requisite review will be done san 4,096 points of pressure sensitivity.

The Surface Go 2 looks and feels like a mini Surface by all accounts, the bezels are similar, the aspect ratios (albeit shrunken) are similar, camera and speaker placements are the same and even the miniature keyboard attachment connects the same pogo pins with the same satisfying click noise. So far, my experience with the Surface Go 2 has been relatively positive. I’m limiting myself to working in Windows 10 S like anyone else who purchases the device. Right off the bat though, the limitations of Windows 10 S became apparent, downloading the new Xbox app on Windows 10 couldn’t be performed. While I was able to download games such as State of Decay and Minecraft Dungeons, actually playing them were no-gos.
";
                }
                else if (Headline == "Keanu Reeves auctioning")
                {
                    return @"The Matrix actor Keanu Reeves is hopping on Zoom for charity. According to Fox News, Reeves, 55, is auctioning off a 15-minute Zoom Date for US children's cancer charity Camp Rainbow Gold in Idaho. The bidding has already hit US$16,400 ($25,437) and the auction won't close until June 22, writes Entertainment Weekly. The site states that the value of the call is $US10,000. Bidding, which closes Monday, has already far surpassed that number.

'Bill & Ted.Speed.The Matrix.John Wick. You know him.You love him.This is truly priceless and now you have the chance to Zoom with him from home,' says the auction site. 'Get your questions ready and spend 15 minutes with actor, director, producer and musician, Keanu Reeves.' According to the site, the Zoom call must take place during the week of July 6, 2020 based on 'mutually available dates and times'. Musicians Ally Brooke and Andy Grammer are also offering up a 'mini - concert' and a signed guitar on the site, respectively.

Reeves is currently in the process of returning to the Matrix franchise for the fourth film, and says he owes his return to writer-director Lana Wachowski. 'Lana Wachowski wrote a beautiful script and a wonderful story that resonated with me,' he told Empire Magazine. 'That's the only reason to do it. To work with her again is just amazing.' The experience was 'really special,' he said, going on to say that audiences can 'take some nourishment' from the story. "
;
                }
                else if (Headline == "Rugby league")
                {
                    return @"The Warriors have made some new best friends while under the NRL's strict biosecurity protocols in Australia. When the Warriors moved to the Central Coast last month ahead of the restart of the NRL season, players weren't allowed to leave their accommodation – even for walks – but exceptions were made if they had a pet. To enable players to escape the confines of their homes under the NRL's biosecurity measures to combat the pandemic, Warriors football operations manager Daniel Floyd came up with an idea to bring in dogs from the Central Coast Animal Care Facility so the players could go for walks outside – and make some new furry friends.

'There was a clause that said you could go for a walk if you had a dog so we thought we would ring up the local pound and see if they would send us some dogs,' Floyd told NRL.com. The NRL has since relaxed those protocols but several Warriors players – including Kodi Nikorima, Jazz Tevaga, Josh Curran, Karl Lawton, Wayde Egan, Isaiah Papali'i, Agnatius Paasi, King Vuniyayawa and Leivaha Pulu – were keen to continue with the dog arrangement. One chose our English Staffy because he has an English Staffy at home, another chose Coco because Coco is a nickname of someone special to them, one chose our Rottweiler, Xena, because he has a Rottweiler and one chose our greyhound because he had greyhounds in the past.

Warriors coach Stephen Kearney, recruitment manager Peter O'Sullivan and Floyd also took part. The pound hopes to generate publicity using the Warriors players to find a home for some of the dogs.
";
                }
                else if (Headline == "NRL-2020")
                {
                    return @"Still on one win each, Cronulla and Canterbury can't afford to give away too much more ground if they're to get on level footing with a logjam of finals contenders. The Sharks thought they had turned a corner after beating the Cowboys in round four, but a heavy loss to the previously winless Dragons last week has them under the microscope. On paper Canterbury had a far stiffer opponent last round - premiers the Roosters -  but they were utterly outclassed and need to improve quickly.

Sharks: Fullback Matt Moylan has been named in the reserves after being considered a '50 - 50' chance to play last week with hamstring tightness. Needing to top up their backline stocks, Cronulla signed Bryson Goodwin and Nene Macdonald this week although only Goodwin is included on Cronulla's extended bench for round six. Jack Williams returns to the starting side at lock with Toby Rudolf to come off the interchange, while Siosifa Talakai and Royce Hunt replace Connor Tracey and Scott Sorensen on the bench.The Sharks have won five of their past six games against the Bulldogs.

Bulldogs: Aiden Tolman is again unavailable for selection as he is in the midst of a quarantine period after a negative COVID-19 test. Reimis Smith replaces Nick Meaney in the backline, with Jake Averillo moving to the wing, Renouf To'omaga starts at prop, Sauaso Sue goes to the bench and Kerrod Holland replaces Morgan Harper on the interchange. Bulldogs five-eighth Kieran Foran has won 12 from 15 against the Sharks.
";
                }
                else
                {
                    return @"People living on the east coast are being told to stay out of the water after a 7.4 magnitude earthquake struck early this morning. There is no tsunami threat in the region, but the Civil Defence in Waikato has put out the warning still. 'Please remember that although there was no tsunami threat in the wee hours, the earthquake south of the Kermadec Islands this morning still could cause strong currents,' the notification read. 'So stay out of the water on the East Coast this morning.'

Those worried that the quake had triggered a tsunami were officially told there was no threat - about 50 minutes after the quake struck. A tsunami alert was never issued by the National Emergency Management Agency when the quake hit at 12.50am off the east coast of New Zealand. Please remember that although there was no tsunami threat in the wee hours, the earthquake south of the Kermadec Islands this morning still could cause strong currents so stay out of the water on the east coast this morning. It would be 47 minutes later when those living on that side of the country would know for sure that they were safe from a tsunami.

A spokesman for NEMA told the Herald this morning that a notification was issued on its social media sites, including Twitter, that an assessment was being made to figure out whether or not a tsunami had been triggered. That notification appeared on the NEMA Twitter page at 1.07am. Another post saying 'there is no tsunami threat' appeared at 1.37am. Asked why it took so long for that to be established, the spokesman said it took time for scientists to analyse the situation to establish if a tsunami was coming or not. That is why the official advice has always been if an earthquake was 'long or strong - get gone', he said.";
                }

                
            }
        }

        public NewsViewModel()
        {
            _headline = new[]
                {
                    "Earthquake",
                    "Covid-19",
                    "Trans-Tasman Air Start",
                    "New Features For Working People",
                    "McLaren Pays Tribute",
                    "PS5 Reveal Event",
                    "Microsoft Surface Go 2 First Impressions",
                    "Keanu Reeves Auctioning",
                    "Rugby league",
                    "NRL-2020"
                }[s_random.Next(10)];

            var imagePath = "Images/circle_image" + (s_random.Next(7) + 1).ToString() + ".jpg";
            _imageUri = new Uri("ms-appx:///" + imagePath);
        }
    }
}
