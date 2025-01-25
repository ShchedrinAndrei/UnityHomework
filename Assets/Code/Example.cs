using System;
using UnityEngine;

namespace Code
{
    public class Example: MonoBehaviour
    {
        public void Start()
        {
            Hw2();
            var damage = CalculateDamage(100, 1.5);
            Debug.LogWarning($"Damage: {damage}");
        }

        private void Hw2()
        {
            int a = 1;
            long l = 11234134313413413L;
            float f = 3.14f;
            double d = 3.1423234242413d;
            decimal m = 3.1423234242413m;
            bool b = true;
            char c = 'c';
            string s = "string";
            
            Debug.Log(a);
            Debug.Log(l);
            Debug.Log(f);
            Debug.Log(d);
            Debug.Log(m);
            Debug.Log(b);
            Debug.Log(c);
            Debug.Log(s);
        }
        
        private double CalculateDamage(double baseDamage, double multiplier)
        {
            return baseDamage * multiplier;
        }
    }
}