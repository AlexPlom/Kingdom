using Kingdom.Contracts.Units;
using SimpleInjector;

namespace Fightings.Configuration
{
    public static class ContainerSetup
    {
        public static Container CreateContainer()
        {
            Container container = new Container();

            container.Register<ICharacterFactory, CharacterFactory>(Lifestyle.Singleton);

            container.Verify();

            return container;
        }
    }
}
