namespace RocketRace
{
    public static class Factory
    {
        public static int GuyNumber = 0;
        public static Punter GetNameId(string name)
        {
            switch (name)
            {
                case "Jonny":
                    GuyNumber = 0;
                    return new Jonny();

                case "Anil":
                    GuyNumber = 1;
                    return new Anil();

                case "Al":
                    GuyNumber = 2;
                    return new Al();
            }
            return new Jonny();
        }
    }
}
