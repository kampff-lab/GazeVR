using System;
using Bonsai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GazeVR
{

    public class RandomBoolean : Combinator<Random, Boolean>
    {
        public override IObservable<bool> Process(IObservable<Random> source)
        {
            return source.Select(random =>
            {
                return (random.NextDouble() < 0.5);
            });
       }
    }

}