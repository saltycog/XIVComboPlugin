namespace XIVComboPlugin.JobActions
{
    using System.IO;


    public static class RPR
    {
        public const byte JobID = 39;

        public const uint
            // Single Target
            Slice = 24373,
            WaxingSlice = 24374,
            InfernalSlice = 24375,
            // AoE
            SpinningScythe = 24376,
            NightmareScythe = 24377,
            // Shroud
            Enshroud = 24394,
            Communio = 24398,
            // Avatar Attacks
            BloodStalk = 0,
            GrimSwathe = 24392,
            // Other
            Guillotine = 24384;
                

        public static class Buffs
        {
            public const short
                Enshrouded = 2593;
            public const short
                SoulReaver = 2587;
        }

        public static class Debuffs
        {
            public const short
                Placeholder = 0;
        }

        public static class Levels
        {
            public const byte
                Slice = 1,
                WaxingSlice = 5,
                SpinningScythe = 25,
                InfernalSlice = 30,
                NightmareScythe = 45,
                Guillotine = 70,
                Enshroud = 80,
                Communio = 90;
        }
    }
}