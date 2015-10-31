using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyFactory1
{
    public class EnemyFactory
    {
        public object Create(bool isBoss)
        {
            if (isBoss)
            {
                return new BossEnemy();
            }
            return new NormalEnemy();
        }
    }

    public class NormalEnemy : Enemy
    {
    }

    public class Enemy
    {
    }

    public class BossEnemy : Enemy
    {
        public int ExtraPower
        {
            get { return 42; }
        }
    }
}
