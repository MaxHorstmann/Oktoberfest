using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace Oktoberfest
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Greeting = new ObservableCollection<ItemViewModel>();
            this.Drinking = new ObservableCollection<ItemViewModel>();
            this.Eating = new ObservableCollection<ItemViewModel>();
            this.Dancing = new ObservableCollection<ItemViewModel>();
            this.Flirting = new ObservableCollection<ItemViewModel>();
            this.Swearing = new ObservableCollection<ItemViewModel>();
            this.Leaving = new ObservableCollection<ItemViewModel>();
            

        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Greeting { get; private set; }
        public ObservableCollection<ItemViewModel> Drinking { get; private set; }
        public ObservableCollection<ItemViewModel> Eating { get; private set; }
        public ObservableCollection<ItemViewModel> Dancing { get; private set; }
        public ObservableCollection<ItemViewModel> Flirting { get; private set; }
        public ObservableCollection<ItemViewModel> Swearing { get; private set; }
        public ObservableCollection<ItemViewModel> Leaving { get; private set; }
      

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "Hi dude!", GermanPhrase = "Servus Alter!"});
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "Hi everyone!", GermanPhrase = "Servus miteinander!" });
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "How are you?", GermanPhrase = "Wie geht's, wie steht's?" });
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "My name is John.", GermanPhrase = "Ich bin der John." });
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "What's your name?", GermanPhrase = "Wer bist DU denn?" });
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "Where are you from?", GermanPhrase = "Wo kommt ihr Typen her?" });
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "I'm from Texas.", GermanPhrase = "Ich bin aus Texas." });
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "This is my wife.", GermanPhrase = "Das ist meine Alte." });
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "Nice meeting you!", GermanPhrase = "Freut mich euch kennenzulernen!" });
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "Can we join?", GermanPhrase = "Können wir uns zu euch setzen?" });
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "Can we sit here?", GermanPhrase = "Können wir uns hier hinsetzen?" });
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "Any free seats?", GermanPhrase = "Hier noch was frei irgendwo?" });
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "We are 4 people.", GermanPhrase = "Wir sind zu viert." });
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "We'll have fun!", GermanPhrase = "Wir lassen's heute krachen, Leute!" });
            this.Greeting.Add(new ItemViewModel() { EnglishPhrase = "Here we are!", GermanPhrase = "So, da sind wir!" });


            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "One beer, please!", GermanPhrase = "Ein Bier, bitte!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "And another one!", GermanPhrase = "Und noch eins!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "That's a huge beer!", GermanPhrase = "Das ist aber ein großes Bier!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "Keep the change!", GermanPhrase = "Stimmt so!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "Cheers, everyone!", GermanPhrase = "Prost miteinander!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "Next round on me!", GermanPhrase = "Nächste Runde geht auf mich!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "We'll drink today!", GermanPhrase = "Heute wird gesoffen bis zum Abwwinken!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "That's my 5th beer!", GermanPhrase = "Das ist schon mein fünftes Bier!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "Round of shots!", GermanPhrase = "Und jetzt eine Runde Schnaps!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "Round of Jäger!", GermanPhrase = "Und jetzt eine Runde Jägermeister!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "Beer mugs up!", GermanPhrase = "Die Krüge hoch!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "I'll shoot my beer!", GermanPhrase = "Ich trink mein Bier jetzt auf Ex!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "Drink, drink, drink!", GermanPhrase = "Saufen, Saufen, Saufen!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "Awesome here!", GermanPhrase = "Geile Stimmung hier!" });
            this.Drinking.Add(new ItemViewModel() { EnglishPhrase = "This is paradise!", GermanPhrase = "Wir sind im Paradies hier!" });

            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "I'm getting hungry.", GermanPhrase = "Ich krieg langsam Kohldampf." });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "You guys wanna eat?", GermanPhrase = "Wie schaut's aus mit was zu Essen?" });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "Can I get a Pretzel?", GermanPhrase = "Krieg ich eine Brezel?" });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "Pretzel with mustard!", GermanPhrase = "Eine Brezel mit scharfem Senf!" });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "One sausage!", GermanPhrase = "Ich nehm dann mal eine Wurst." });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "Bring me a Schnitzel!", GermanPhrase = "Bringst du mir ein Schnitzel?" });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "Bread & Obazda.", GermanPhrase = "Ein Brot mit Obazda!" });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "Knuckle of pork!", GermanPhrase = "Eine Schweinshaxe!" });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "Cheese meat loaf!", GermanPhrase = "Ein Leberkäse für mich!" });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "Enjoy your meal!", GermanPhrase = "Einen guten allerseits, lasst's euch schmecken!" });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "That's a lot of food.", GermanPhrase = "Die Portionen sind ja wirklich ordentlich!" });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "I'll eat it all!", GermanPhrase = "Das ess ich alles auf!" });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "My groundwork...", GermanPhrase = "Das ist meine Grundlage für später..." });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "Now those pancakes!", GermanPhrase = "Jetzt noch ein Kaiserschmarrn!" });
            this.Eating.Add(new ItemViewModel() { EnglishPhrase = "Now I'm full.", GermanPhrase = "Jetzt bin ich aber satt." });


            this.Dancing.Add(new ItemViewModel() { EnglishPhrase = "Dance on the table!", GermanPhrase = "Auf geht's, wir tanzen auf dem Tisch!" });
            this.Dancing.Add(new ItemViewModel() { EnglishPhrase = "Wanna dance?", GermanPhrase = "Möchtest du mit mir tanzen?" });
            this.Dancing.Add(new ItemViewModel() { EnglishPhrase = "Does she dance?", GermanPhrase = "Tanzt sie auch?" });
            this.Dancing.Add(new ItemViewModel() { EnglishPhrase = "Shake your body!", GermanPhrase = "Los, wackel mit allem was du hast!" });
            this.Dancing.Add(new ItemViewModel() { EnglishPhrase = "Let's sway!", GermanPhrase = "Jetzt wird kräftig geschunkelt!" });
            this.Dancing.Add(new ItemViewModel() { EnglishPhrase = "Not so tight!", GermanPhrase = "Komm schon, nicht so steif hier!" });
            this.Dancing.Add(new ItemViewModel() { EnglishPhrase = "I love Blasmusik!", GermanPhrase = "Die Blasmusik ist echt der Kracher!" });
            this.Dancing.Add(new ItemViewModel() { EnglishPhrase = "My favorite song!", GermanPhrase = "Das ist mein Lieblingslied!" });
            this.Dancing.Add(new ItemViewModel() { EnglishPhrase = "I can't dance.", GermanPhrase = "Ich kann gar nicht tanzen." });
            this.Dancing.Add(new ItemViewModel() { EnglishPhrase = "But who cares?", GermanPhrase = "Aber ist ist ja wohl wurscht!" });
            this.Dancing.Add(new ItemViewModel() { EnglishPhrase = "One, two, three!", GermanPhrase = "Eins, zwei, drei!" });
            this.Dancing.Add(new ItemViewModel() { EnglishPhrase = "Enough dancing.", GermanPhrase = "Jetzt ist erstmal gut mit Tanzen." });
            this.Dancing.Add(new ItemViewModel() { EnglishPhrase = "Later again, maybe.", GermanPhrase = "Nachher dann vielleicht wieder." });


            this.Flirting.Add(new ItemViewModel() { EnglishPhrase = "You've beautiful eyes!", GermanPhrase = "Du hast wunderschöne Augen!" });
            this.Flirting.Add(new ItemViewModel() { EnglishPhrase = "My stamp collection?", GermanPhrase = "Wie wär's ich zeig dir mal meine Briefmarken- Sammlung?" });
            this.Flirting.Add(new ItemViewModel() { EnglishPhrase = "You're not my type.", GermanPhrase = "Du bist nicht mein Typ." });
            this.Flirting.Add(new ItemViewModel() { EnglishPhrase = "Lots in common!", GermanPhrase = "Wir beide haben so viel gemeinsam!" });
            this.Flirting.Add(new ItemViewModel() { EnglishPhrase = "Can I buy u a drink?", GermanPhrase = "Kann ich dir einen ausgeben?" });
            this.Flirting.Add(new ItemViewModel() { EnglishPhrase = "Can I call you?", GermanPhrase = "Gibst du mir deine Telefon- nummer?" });
            this.Flirting.Add(new ItemViewModel() { EnglishPhrase = "I love you!", GermanPhrase = "Ich liebe dich!" });

            this.Swearing.Add(new ItemViewModel() { EnglishPhrase = "Shit!", GermanPhrase = "Verdammte Scheiße!" });
            this.Swearing.Add(new ItemViewModel() { EnglishPhrase = "Go out and fight?", GermanPhrase = "Gehen wir raus und tragen's aus?" });
            this.Swearing.Add(new ItemViewModel() { EnglishPhrase = "You guys are boring!", GermanPhrase = "Ihr seid so langweilig, da schlaf ich ein!" });
            this.Swearing.Add(new ItemViewModel() { EnglishPhrase = "Damn I'm drunk!", GermanPhrase = "Scheiße bin ich besoffen!" });
            this.Swearing.Add(new ItemViewModel() { EnglishPhrase = "Nobody loves me!", GermanPhrase = "Niemand hat mich lieb!" });

            this.Leaving.Add(new ItemViewModel() { EnglishPhrase = "We're leaving soon.", GermanPhrase = "Wir hauen dann gleich ab." });
            this.Leaving.Add(new ItemViewModel() { EnglishPhrase = "Nice hanging out!", GermanPhrase = "Hat mich gefreut mit euch abzuhängen!" });
            this.Leaving.Add(new ItemViewModel() { EnglishPhrase = "Back next year!", GermanPhrase = "Nächstes Jahr sind wir wieder am Start!" });
            this.Leaving.Add(new ItemViewModel() { EnglishPhrase = "Come visit us!", GermanPhrase = "Kommt uns mal besuchen!" });
            this.Leaving.Add(new ItemViewModel() { EnglishPhrase = "You guys: awesome!", GermanPhrase = "Ihr wart die coolsten Typen aller Zeiten!" });
            this.Leaving.Add(new ItemViewModel() { EnglishPhrase = "Add me on Facebook!", GermanPhrase = "Lasst uns auf Facebook befreunden!" });
            this.Leaving.Add(new ItemViewModel() { EnglishPhrase = "Going another place?", GermanPhrase = "Geht ihr noch irgendwo anders hin?" });
            this.Leaving.Add(new ItemViewModel() { EnglishPhrase = "We had so much fun!", GermanPhrase = "Hat hammermäßig Spaß gemacht!" });
            this.Leaving.Add(new ItemViewModel() { EnglishPhrase = "Oktoberfest rules!", GermanPhrase = "Oktoberfest ist echt das geilste!" });
            this.Leaving.Add(new ItemViewModel() { EnglishPhrase = "Or, one more drink?", GermanPhrase = "Oder trinken wir doch noch einen?" });
            this.Leaving.Add(new ItemViewModel() { EnglishPhrase = "Alright, last beer!", GermanPhrase = "Gut, das ist jetzt aber das letzte Bier!" });
            this.Leaving.Add(new ItemViewModel() { EnglishPhrase = "Bye!", GermanPhrase = "Tschüß und Servus!" });
            this.Leaving.Add(new ItemViewModel() { EnglishPhrase = "Who paid the check?", GermanPhrase = "Hat eigentlich irgendjemand die Rechnung bezahlt?" });


            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}