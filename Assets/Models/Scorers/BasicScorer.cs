namespace UnityDemo.Models.Scorers
{
    public class BasicScorer : Scorer
    {
        public override Player GetWinner(Player p1, Player p2)
        {
            int score1 = CalculateScore(p1);
            int score2 = CalculateScore(p2);

            if (score1 > score2)
                return p1;
            else
                return p2;
        }

        private int CalculateScore(Player player)
        {
            //player의 첫번째 카드와 두번째 카드가 광일 경우에는 101의 점수를 반환한다.
            if (player[0].IsKwang && player[1].IsKwang)
                return 101;

            //player의 첫번째 카드와 두번째 카드가 같은 숫자일 경우에 숫자에 10을 곱한다.
            else if (player[0].No == player[1].No)
                return player[0].No * 10;

            //player의 첫번째 카드와 두번째 카드가 광이 아닐 경우에는 두 숫자를 더한 후에 10을 나눈다.
            else
                return (player[0].No + player[1].No) % 10;
        }
    }
}