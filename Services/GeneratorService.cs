using funnypassgenwasm.Models;
using System;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace funnypassgenwasm.Services
{
    public class GeneratorService
    {
        static Random random = new Random();

        public static string GeneratePassword(PasswordOptions passwordOptions)
        {
            string password = "";
            
            string[] allFunnyWords = [
            "airhead",
            "armpit",
            "arsegoblin",
            "assclown",
            "ballsack",
            "bamboozle",
            "bastard",
            "bedswerver",
            "bewildered",
            "bimbo",
            "bitchslap",
            "biteme",
            "blubbering",
            "boink",
            "bootycall",
            "bouffant",
            "bozo",
            "bulbous",
            "bullcrap",
            "bumblefuck",
            "bumfuzzle",
            "buttface",
            "cameltoe",
            "cattywampus",
            "chucklefuck",
            "churlish",
            "cornhole",
            "crabshack",
            "dickweed",
            "dildo",
            "dingleberry",
            "dingus",
            "dingbat",
            "dirty",
            "dogfart",
            "dongle",
            "doohickey",
            "douchenozzle",
            "eggplant",
            "erectile",
            "erogenous",
            "filthy",
            "flabergast",
            "flapjack",
            "flatulence",
            "fondle",
            "fubar",
            "fucktrumpet",
            "fugly",
            "geezer",
            "genital",
            "gibberish",
            "gonads",
            "goofball",
            "hullaballoo",
            "labradoodle",
            "lollygag",
            "lube",
            "herpes",
            "hillbilly",
            "hogwash",
            "horny",
            "jackass",
            "jackwagon",
            "kerfuffle",
            "knockers",
            "knucklehead",
            "malarkey",
            "milf",
            "moist",
            "mooch",
            "moronic",
            "nasty",
            "nincompoop",
            "ninnymuggins",
            "nipple",
            "noob",
            "oddball",
            "peckerwood",
            "peehole",
            "penile",
            "pipsqueak",
            "pitiful",
            "poontang",
            "porno",
            "quagmire",
            "quickie",
            "redneck",
            "repugnant",
            "sausage",
            "scalawag",
            "schmuck",
            "scrotum",
            "scummy",
            "shaggin",
            "shenanigans",
            "shithead",
            "skedaddle",
            "smorgasboard",
            "snockered",
            "snollygoster",
            "sphincter",
            "squeegee",
            "stanky",
            "stripclub",
            "taint",
            "testicle",
            "titdirt",
            "tatertits",
            "tomfoolery",
            "twerp",
            "vibrator",
            "wanker",
            "yellowbelly",
            "yomama"
            ];

            string[] seedWords = [];

            seedWords = ShuffleAndExtract(allFunnyWords);

            if (passwordOptions.Capitalize)
            {
                seedWords = Capitalize(seedWords);
            }

            password = String.Join(passwordOptions.SeparatorChar, seedWords);

            if (passwordOptions.AddNumber)
            {
                password += random.Next(10);
            }

            return password;


            string[] ShuffleAndExtract(string[] arrayToShuffleAndExtract)
            {
                return arrayToShuffleAndExtract.OrderBy(_ => random.Next())
                            .Take(passwordOptions.NumberOfWords).ToArray();
            }

            string[] Capitalize(string[] arrayToCapitalize)
            {
                return arrayToCapitalize.Select(word => word[0].ToString().ToUpper() + word.Substring(1)).ToArray();
            }
        }

    }
}