using UnityEngine;

[System.Serializable]
public class WordPrompts
{
    public string targetWord;
    public string[] bannedWords;
}

public class QuestionMaker : MonoBehaviour
{
    public WordPrompts[] allPrompts;

    void Awake()
    {
        //make sure all WordPrompts have exactly 5 banned words

        allPrompts = new WordPrompts[]
        {
            new WordPrompts { targetWord = "Surah Fatiha", bannedWords = new string[]{"First","Last","Quran","Makkah","Surah"}},
            new WordPrompts { targetWord = "Rasulullah (PBUH)", bannedWords = new string[]{"Khadija","Husband","Prophet","Messenger","Last"}},
            new WordPrompts { targetWord = "Ramadan", bannedWords = new string[]{"Fast","Holy","Month","Quran","Dates"}},
            new WordPrompts { targetWord = "Zakat", bannedWords = new string[]{"5th","2.50%","Charity","Sadaqah","Pillar"}},
            new WordPrompts { targetWord = "Halal", bannedWords = new string[]{"Food","Permissible","Edible","Allowed","Haram"}},
            new WordPrompts { targetWord = "Jannah", bannedWords = new string[]{"Good","Reward","Heaven","Paradise","Opposite"}},
            new WordPrompts { targetWord = "Quran", bannedWords = new string[]{"Muhammad (PBUH)","Ramadan","Book","Salah","Allah"}},
            new WordPrompts { targetWord = "Makkah", bannedWords = new string[]{"Muahmmad (SAW)", "Pilgrimage","Hajj","Medina","Kaaba"}},
            new WordPrompts { targetWord = "Masjid", bannedWords = new string[]{"Precious","Holy","Peace","House","Prayer"}},
            new WordPrompts { targetWord = "Isa (AS)", bannedWords = new string[]{"Gaza/Palestine","Jannah","Guidance","Free","Isa"}},
            new WordPrompts { targetWord = "Surah Al-Kahf", bannedWords = new string[]{"Palestine","Dajjal","Rome","Kahf","Group"}},
            new WordPrompts { targetWord = "5 Pillars", bannedWords = new string[]{"Salah","Cave","7 Heavens","Islam","Mandatory"}},
            new WordPrompts { targetWord = "Hajj", bannedWords = new string[]{"Kaaba","Mecca","Pilgrimage","Rock","Travel"}},
            new WordPrompts { targetWord = "Zakat", bannedWords = new string[]{"Money","Charity","Poor","Islam","Donation"}},
            new WordPrompts { targetWord = "Ramadan", bannedWords = new string[]{"Fasting","Month","Quran","Suhoor","Iftar"}},
            new WordPrompts { targetWord = "Prophet Muhammad", bannedWords = new string[]{"Messenger","Islam","Quran","Allah","Final"}},
            new WordPrompts { targetWord = "Quran", bannedWords = new string[]{"Book","Islam","Arabic","Read","Surah"}},
            new WordPrompts { targetWord = "Salah", bannedWords = new string[]{"Pray","Five","Times","Islam","Mosque"}},
            new WordPrompts { targetWord = "Eid", bannedWords = new string[]{"Festival","Muslim","Sacrifice","Prayer","Celebration"}},
            new WordPrompts { targetWord = "Wudu", bannedWords = new string[]{"Wash","Before","Pray","Clean","Water"}},
            new WordPrompts { targetWord = "Mosque", bannedWords = new string[]{"Allah","Building","Islam","Worship","Jummah"}},
            new WordPrompts { targetWord = "Shahada", bannedWords = new string[]{"Declaration","Faith","Allah","Muhammad","One"}},
            new WordPrompts { targetWord = "Imam", bannedWords = new string[]{"Leader","Prayer","Mosque","Guide","Islam"}},
            new WordPrompts { targetWord = "Jahannam", bannedWords = new string[]{"Hell","Fire","Punishment","Afterlife","Jannah"}},
            new WordPrompts { targetWord = "Angels", bannedWords = new string[]{"Malaika","Created","Light","Messenger","Islam"}},
            new WordPrompts { targetWord = "Musa (AS)", bannedWords = new string[]{"Pharaoh","Ismael","Torah","Messenger","Prophet"}},
            new WordPrompts { targetWord = "Ibrahim (AS)", bannedWords = new string[]{"Sacrifice","Father","Messenger","Kaaba","Islam"}},
            new WordPrompts { targetWord = "Yusuf (AS)", bannedWords = new string[]{"Dream","Brothers","Egypt","Messenger","Hasrat Yaqub"}},
            new WordPrompts { targetWord = "Medina", bannedWords = new string[]{"City","Prophet","Mosque","Migration","Islam"}},
            new WordPrompts { targetWord = "Mecca", bannedWords = new string[]{"City","Kaaba","Hajj","Umrah","Islam"}},
            new WordPrompts { targetWord = "Hijra", bannedWords = new string[]{"Migration","Mecca","Medina","Prophet","Islam"}},
            new WordPrompts { targetWord = "Jibril", bannedWords = new string[]{"Angel","Revelation","Messenger","Islam","Quran"}},
            new WordPrompts { targetWord = "Qibla", bannedWords = new string[]{"Direction","Pray","Kaaba","Islam","Face"}},
            new WordPrompts { targetWord = "Umrah", bannedWords = new string[]{"Lesser","Hajj","Pilgrimage","Mecca","Islam"}},
            new WordPrompts { targetWord = "Takbir", bannedWords = new string[]{"Allahu Akbar","Phrase","Islam","Say","Prayer"}},
            new WordPrompts { targetWord = "Tasbih", bannedWords = new string[]{"SubhanAllah","Dhikr","Remember","Islam","Praise"}},
            new WordPrompts { targetWord = "Dua", bannedWords = new string[]{"Supplication","Ask","Allah","Pray","Islam"}},
            new WordPrompts { targetWord = "Hadith", bannedWords = new string[]{"Saying","Prophet","Islam","Collection","Teachings"}},
            new WordPrompts { targetWord = "Hijab", bannedWords = new string[]{"Cover","Women","Hair","Islam","Clothing"}},
            new WordPrompts { targetWord = "Janazah", bannedWords = new string[]{"Funeral","Prayer","Islam","Death","Body"}},
            new WordPrompts { targetWord = "Fajr", bannedWords = new string[]{"Morning","Prayer","First","Islam","Time"}},
            new WordPrompts { targetWord = "Dhuhr", bannedWords = new string[]{"Noon","Prayer","Islam","Time","Second"}},
            new WordPrompts { targetWord = "Asr", bannedWords = new string[]{"Afternoon","Prayer","Islam","Time","Third"}},
            new WordPrompts { targetWord = "Maghrib", bannedWords = new string[]{"Evening","Prayer","Islam","Time","Fourth"}},
            new WordPrompts { targetWord = "Isha", bannedWords = new string[]{"Night","Prayer","Islam","Time","5th"}},
            new WordPrompts { targetWord = "Sunnah", bannedWords = new string[]{"Prophet","Actions","Islam","Follow","Teachings"}},
            new WordPrompts { targetWord = "Ummah", bannedWords = new string[]{"Community","Islam","Muslim","Together","Nation"}},
            new WordPrompts { targetWord = "Adhan", bannedWords = new string[]{"Call","Prayer","Mosque","Islam","Prayer"}},
            new WordPrompts { targetWord = "Iqamah", bannedWords = new string[]{"Prayer","Announce","Islam","Mosque","Start"}},
            new WordPrompts { targetWord = "Sadaqah", bannedWords = new string[]{"Charity","Islam","Give","Donation","Help"}},
            new WordPrompts { targetWord = "Laylat al-Qadr", bannedWords = new string[]{"Night","Quran","Ramadan","Islam","Better"}},
            new WordPrompts { targetWord = "Abu Bakr", bannedWords = new string[]{"As-Siddiq","Companion","Prophet","Islam","Friend"}},
        };
    }
}
