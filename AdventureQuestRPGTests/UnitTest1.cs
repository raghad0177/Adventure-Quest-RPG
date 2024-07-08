using AdventureQuestRPG;

namespace AdventureQuestRPGTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Raghad", 10, 9, 3, 4)]
        [InlineData("Monester", 10, 6, 3, 7)]
        public void HealthTest(string name, int health, int attackpower, int defense, int expectedHealth)
        {
            //Arrange
            Player attacker = new Player(name, health, attackpower, defense);
            Monster target = new Monster(name, health, attackpower, defense);
            //Act
            int result = BattleSystem.Attack(attacker, target);
            //Assert
            Assert.Equal(expectedHealth, target.Health);
        }
        [Fact]
        public void WinnerTest()
        {
            //Arrange
            Player attacker = new Player("Raghad", 14, 9, 3);
            Monster target = new Monster("Monester", 10, 6, 3);
            //Act
            int result = BattleSystem.StartBattle(attacker, target);
            //Assert
            Assert.True(result > 0);  
        }
    }
}