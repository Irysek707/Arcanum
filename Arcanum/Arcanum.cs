using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Arcanum
{
    public partial class Arcanum : Form

    {
        public int Number { get; set; }


        public Arcanum()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\background.wav";
            sp.PlayLooping();

            date.Visible = false;
            birthday.Visible = false;
            calculate.Visible = false;
            backBtn.Visible = false;
            zodiac.Visible = false;
            numb.Visible = false;
            zodiacTxt.Visible = false;
            numberTxt.Visible = false;
            aries.Visible = false;
            taurus.Visible = false;
            gemini.Visible = false;
            cancer.Visible = false;
            leo.Visible = false;
            virgo.Visible = false;
            libra.Visible = false;
            scorpio.Visible = false;
            sagittarius.Visible = false;
            capricorn.Visible = false;
            aquarius.Visible = false;
            pisces.Visible = false;

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Visible = false;
            introductionTxt.Visible = false;
            backBtn.Visible = false;

            date.Visible = true;
            birthday.Visible = true;
            calculate.Visible = true;


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void soundBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\background.wav";
            sp.PlayLooping();

            soundBtn.Visible = false;
            muteBtn.Visible = true;
        }

        private void muteBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\background.wav";
            sp.Stop();

            muteBtn.Visible = false;
            soundBtn.Visible = true;
        }
        private int SumNumbers(int number)
        {
            if (number < 10 || number == 11 || number == 22 || number == 33 || number == 44)
                return number;

            string stringNumber = number.ToString();

            int newNumber = 0;
            for (int i = 0; i < stringNumber.Length; i++)
            {
                char c = stringNumber[i];
                int charNumber = int.Parse(c.ToString());

                newNumber += charNumber;
            }

            return SumNumbers(newNumber);
        }

            private void birthday_ValueChanged(object sender, EventArgs e)
            {
                DateTime date = birthday.Value;
                int day = date.Day;
                int month = date.Month;
                int year = date.Year;

                int sum = day + month + year;
                sum = SumNumbers(sum);

                numb.Text = "Number " + sum.ToString();
                Number = sum;

            if (Number.Equals(1))
                numberTxt.Text = "Of all the numbers in Numerology, the 1 is the most self-sufficient, needing nothing but itself and its energy to thrive. It doesn't sit around waiting for opportunities to come about, it makes its own luck by capitalizing on circumstances others may be afraid to explore. The single-digit number 1 doesn't want to waste any time getting stuck negotiating or discussing plans. Going it alone allows for greater flexibility and quick, efficient movement.";

            if (Number.Equals(2))
                numberTxt.Text = "On a very deep and subconscious level, this number can pick up on energies that cannot be seen, only felt. This trait allows the number 2 to be instinctually aware of feelings, thoughts, hopes, and fears others haven't even expressed, then use them as opportunities to offer support and compassion to the partnership.";

            if (Number.Equals(3))
                numberTxt.Text = "The 3 is a communicator through and through and shines in all forms of expression. It is bursting with thoughts, ideas, dreams, and musings and must let them out to the world. The number 3 is the 'ideas person' and by sharing these notions it attracts supportive energies that can turn its ideas into real plans.";

            if (Number.Equals(4))
                numberTxt.Text = "The 4 has a realistic outlook on life and isn't swayed by the newest or shiniest object, experience, or idea. This rationality allows it to make wise decisions and develop solid plans that can really move the meter. For the 4, practicality is the root of productivity.";

            if (Number.Equals(5))
                numberTxt.Text = "The opposite of tunnel vision, the Numerology number 5 has 360-degree vision and everything it sees looks enticing. This curious nature leads it into a variety of exciting and enlightening new experiences few others may have. For the 5, the best way to learn is to experiment.";

            if (Number.Equals(6))
                numberTxt.Text = "When a shoulder is needed to lean on, the number 6 will be the first to arrive, equipped with a kind, soft presence and heartfelt advice. It does not simply wait to speak -- it truly listens and seeks to understand so it can direct its compassion and healing where it is needed most.";

            if (Number.Equals(7))
                numberTxt.Text = "The 7's understanding that there is always something deeper, something more we can't see, instills in it a great sense of spirituality. While religion is too limiting for this boundless number, a very personal, intellectual connection to the spiritual world gives its experiences more mystery and meaning.";

            if (Number.Equals(8))
                numberTxt.Text = "To say the 8 has ambition would be putting it lightly -- they live to achieve! This number is on a mission to reach as many goals and garner as much success as possible. It is strategic in its methods and dedicated to its purpose. The good feelings that come from accomplishment give the 8 everything it needs to keep climbing upward.";

            if (Number.Equals(9))
                numberTxt.Text = "Through life experience, the number 9 in Numerology has learned the value and magnitude of its inner wisdom. It is now in a position to awaken others to their own higher self. Leading by example, the 9 shows how to handle hardship with grace and understanding, inspiring others to do the same.";

            if (Number.Equals(11))
                numberTxt.Text = "To be born with a Life Path Number 11 is a genuine blessing, yet it may take many years before these people are able to understand the power of their gifts. A Master Number Life Path often feels like a heavy burden because, in order to learn how to trust and hone their unique skills, these people are put through many difficult experiences. They are not meant to be roadblocks or deterrents; this is the universe's way of guiding these chosen ones toward their life purpose. For people with a Master Number 11 Life Path, the trials they go through are intended to help them reach a state of enlightenment -- to strengthen their intuition, put full trust in their instincts, and increase their emotional awareness of the world.";

            if (Number.Equals(22))
                numberTxt.Text = "Those who are lucky enough to be born with a 22 Life Path have the ability to achieve truly great things, but for a long time, this Life Path number may not feel very lucky at all. While people with Master Number Life Paths are capable of reaching a higher potential than others, there are lessons that must be experienced and learned in order to realize this potential. Life will put these people through the wringer so that they may sharpen their skills and learn to trust their abilities. People with a Life Path number 22 may face many trials where they will have to rely on their instincts, enhance their methods, and ask for support to make it through. Though Master Number Life Paths take years to master, the effort is worth it for what these people can ultimately achieve.";

            if (Number.Equals(33))
                numberTxt.Text = "The 33 Life Path is quite rare -- it takes a specific and uncommon combination of numbers in a person's birth date to add up to 33. People born under this Life Path number have been chosen to receive a level of love, compassion, and spiritual understanding that others cannot fathom, but this blessing does not come easily. In order to realize the true magnitude of their potential, people with Master Number Life Paths will experience difficult trials throughout life. The universe puts these people in these situations so they may hone their unique skills and learn the lessons needed to reach their potential. For those with a 33 Life Path number, they must first heal and nurture their own souls before they can be a source of healing for others. Therefore, they will be put in situations that require them to accept responsibility for their actions and reactions, practice forgiveness, and put their interests aside for the sake of others. It can take the better part of a lifetime before a person fully masters the 33 Life Path, but when they do, their level of enlightenment is magnificent.";

            if (Number.Equals(44))
                numberTxt.Text = "An individual that has life path number 44 is here to accomplish more than most. Therefore, they have passion and energy to engage in material matters on a large scale, in a grand manner, and powerfully. Their personality develops through their efforts to maximize the experience of being physical on the physical plane of earth. As people, they embrace science, commerce, technology, and politics.Therefore, they become successful through finding their worldly purpose. Since they act with Destiny’s blessing, they overcome challenges thrown in their way by leading with absolute confidence, thus shaping the destiny they must confront and the world needs them to produce.";


            if (day >= 21 && month == 3 || day <= 19 && month == 4)
                zodiac.Text = "Aries";
                zodiacTxt.Text = "When they speak, you follow, making them a bit bossy at times. They are the confident friend who will make you talk to your crush for the first time. They can be a bit intimidating because they are so strong, so when trying to be their friend- just be chill. They will be the first people to audition for theatre musical and not be afraid to sing a solo in choir. Maybe even go behind Mr. Cope’s back, and dare you to climb the rock climbing wall, ending in you both getting into trouble.";

            if (day >= 20 && month == 4 || day <= 20 && month == 5)
                zodiac.Text = "Taurus";
                zodiacTxt.Text = "The friend who will constantly make you feel loved and appreciated. Commonly known as the sign of the foodies. They won’t hesitate to get into a fight with you because you stole their french fry on hamburger day, and will make you stay in the cafeteria so they can repeat their taco. They go by the saying “quality over quantity”, which can be seen in their fashion sense. Taureans love splurging on items, making them a great shopping buddy. The best sign in the entire horoscope. That has nothing to do with the fact that I’m a Taurus.";

            if (day >= 21 && month == 5 || day <= 21 && month == 6)
                zodiac.Text = "Gemini";
                zodiacTxt.Text = "The twin sign. Two faced, even. They can change their mood faster than you can even blink. One day they say your summative is due on Tuesday, the next day they say that they’re changing the entire assignment. You never know who you’re going to get with a Gemini. They are like a chameleon, who can change their personality due to the vibe of a group and atmosphere. An incredibly smart and passionate sign. They’re very witty and energetic; a glass-half-full sort of person.";

            if (day >= 22 && month == 6 || day <= 22 && month == 7)
                zodiac.Text = "Cancer";
                zodiacTxt.Text = "The most lovable person in the world. They will do everything to make you happy. If you want to have a romcom movie marathon, they are the ones to call. They will likely show up with candy bars also. To them, little things matter. They will take the time to do a small act because they know it will cheer you up. They will cry when you go to CWW, and you hear someone talking about a sad past experience. They’re the friend you go to for venting. They will mostly cry with you half the time, which can be counterproductive, but at least you know they care.";

            if (day >= 23 && month == 7 || day <= 22 && month == 8)
                zodiac.Text = "Leo";
                zodiacTxt.Text = "Very bold and courageous, they are of one the few signs that will fight to the death in order to help you. The person who yells the senior’s chant in assembly. They will also likely get daily detention for being late to class because they were talking to their friends in the hall. Can be a little hard to handle, and around them, you will definitely have to become the “mom” friend. They will force you to participate in a karaoke contest, and party with you until you drop. They will dance in heels for the entire night, and make friends with everyone at the party. Can get a little annoying once they ditch you for a stranger they met in the bathroom. Very worth it though, they are the best party companion.";

            if (day >= 23 && month == 8 || day <= 22 && month == 9)
                zodiac.Text = "Virgo";
                zodiacTxt.Text = "Highly intelligent. They will have a plan ready before you even need one. The Knowledge Bowl club leaders and Presidents of StuCo. They will get into an Ivy League school because they’ve got the Eagle Award since freshman year. The one who will tell you to text them once you get home, and to be responsible when you’re going out. Their attention to detail is like none other. Virgo’s are organized and efficient. They are the boss who brings a company from bankruptcy to making millions of dollars. They can come off as a little high maintenance because they will get mad when one little book is missing from their shelf. The Monica Geller of the group.";

            if (day >= 23 && month == 9 || day <= 23 && month == 10)
                zodiac.Text = "Libra";
                zodiacTxt.Text = "The sign of fairness. They know equal is different than fair. They will look at every individual person to see what they need. Libra’s also love keeping the peace and will do everything to avoid a conflict. They love Ms. Davenport’s famous mindful moments sessions in class, so they can close their eyes and reflect on their day. Libra’s will be the first person to go to a teacher and argue with them over how they believe their summative grade is unfair. They will talk during a movie because they think that the main character is doing a dumb decision, causing you to pause the movie so they can stop talking. They will probably be a judge or the lawyer. No one can lie to them, or try to finesse them.";

            if (day >= 24 && month == 10 || day <= 21 && month == 11)
                zodiac.Text = "Scorpio";
                zodiacTxt.Text = "Interesting and mysterious. An incredibly passionate and determined sign that fights hard but loves a million times harder. They can come off as mean before you know them, making some rude remarks or rolling their eyes. It’s as if they’re a chocolate truffle. They have a shell on the outside but are very sweet and unexpected on the inside. When they trust you, they will give you their world. They are one of the best friends you will ever make. It was probably a Scorpio who came up with the idea of having a Senior Lawn, so they can have a secluded place from the rest of HS to chill out or work on their assignments.";

            if (day >= 22 && month == 11 || day <= 21 && month == 12)
                zodiac.Text = "Sagittarius";
                zodiacTxt.Text = "They are a free soul. The best PGC leader you’ll ever have. They are the fun friend who will take you to Disney World in the morning and the bowling alley at night. They are the most open-minded, wise, and intelligent sign. They are all very child-like. If you see a high schooler in the lower school playground swinging on the swings, 90% chance they’re a Sagittarius. They can be immature, but when you need them to be serious they can be. If a teacher gets mad at them they will laugh at their face but realize they were wrong, and later for being rude. They are also very blunt. They will tell you if you look bad in an outfit, or if you’re being too dramatic.";

            if (day >= 22 && month == 12 || day <= 19 && month == 1)
                zodiac.Text = "Capricorn";
                zodiacTxt.Text = "The world would not function without them because they get things done on their own. They are very strong people, and if someone tells them that they are weak, they will prove that person wrong. They can be in any leadership position in the school that they want. They are the student that the entire grade votes for to be class representative for StuCo because people trust that they will get stuff done. They are the most hard-working sign. They can be a little boring since they are very work-oriented. If you get a Capricorn to loosen up, they will actually be very fun people. But that’s a big if.";

            if (day >= 20 && month == 1 || day <= 18 && month == 2)
                zodiac.Text = "Aquarius";
                zodiacTxt.Text = "They want to help people, and they do it well. If you listen to them, your life will change. Probably run some sort of happiness club, and will bring cupcakes to their mentoring group because they felt like it. They always want to make the world a better place, and frankly, thanks to them it already is. They are the philanthropists, the people who donate to charity, the teachers, etc. It can be annoying how good of a person they are because they never want to be on anyone’s bad side. They don’t position themselves in an argument, which can hurt at times because they won’t fight with you in a war. They’ll be on the sidelines watching both sides.";

            if (day >= 19 && month == 2 || day <= 20 && month == 3)
                zodiac.Text = "Pisces";
                zodiacTxt.Text = "Wisest sign of them all. They are emotional and caring; they feel whatever you feel. Pisces are the kind of people who always help even if they don’t know you. Counselors, nurses, psychologist and anyone in school you get a more personal support from. Although be warned, if a Pisces gets emotional (which happens a lot), they will never stop crying. They are a romantic comedy as a person. They feel so many emotions, that’s why they will always make sure you are loved. When you hear a story from Ms. Roy that involves a person taking care of her friend at a party, the caretaker is most likely a Pisces.";

        }

            private void calculate_Click(object sender, EventArgs e)
            {
                date.Visible = false;
                birthday.Visible = false;
                calculate.Visible = false;

                backBtn.Visible = true;
                zodiac.Visible = true;
                numb.Visible = true;
                zodiacTxt.Visible = true;
                numberTxt.Visible = true;

            if (zodiac.Text == "Aries")
                aries.Visible = true;

            if (zodiac.Text == "Taurus")
                taurus.Visible = true;

            if (zodiac.Text == "Gemini")
                gemini.Visible = true;

            if (zodiac.Text == "Cancer")
                cancer.Visible = true;

            if (zodiac.Text == "Leo")
                leo.Visible = true;

            if (zodiac.Text == "Virgo")
                virgo.Visible = true;

            if (zodiac.Text == "Libra")
                libra.Visible = true;

            if (zodiac.Text == "Scorpio")
                scorpio.Visible = true;

            if (zodiac.Text == "Sagittarius")
                sagittarius.Visible = true;

            if (zodiac.Text == "Capricorn")
                capricorn.Visible = true;

            if (zodiac.Text == "Aquarius")
                aquarius.Visible = true;

            if (zodiac.Text == "Pisces")
                pisces.Visible = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            backBtn.Visible = false;
            zodiac.Visible = false;
            numb.Visible = false;
            zodiacTxt.Visible = false;
            numberTxt.Visible = false;
            aries.Visible = false;
            taurus.Visible = false;
            gemini.Visible = false;
            cancer.Visible = false;
            leo.Visible = false;
            virgo.Visible = false;
            libra.Visible = false;
            scorpio.Visible = false;
            sagittarius.Visible = false;
            capricorn.Visible = false;
            aquarius.Visible = false;
            pisces.Visible = false;

            introductionTxt.Visible = true;
            startBtn.Visible = true;
        }
    }
}
