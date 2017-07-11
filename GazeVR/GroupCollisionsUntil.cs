using Bonsai;
using Bonsai.Physics.Collision;
using Ode.Net.Collision;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GazeVR
{
    [Combinator]
    [Description("Groups collision events by individual geometry objects until the specified duration event is generated.")]
    public class GroupCollisionsUntil
    {
        public IObservable<IGroupedObservable<Geom, EventPattern<Geom, GeomCollisionEventArgs>>> Process<TDuration>(IObservable<EventPattern<Geom, GeomCollisionEventArgs>> source, IObservable<TDuration> duration)
        {
            return source.GroupByUntil(
                evt => evt.EventArgs.Geom,
                group => duration.TakeUntil(group).Repeat());
        }
    }
}
