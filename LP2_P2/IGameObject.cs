using System;
using System.Collections;
namespace LP2_P2
{
    /// <summary>
    /// Game object interface.
    /// </summary>
    public interface IGameObject
    {
        /// <summary>
        /// Method to be used by other classes that implement IGameObject.
        /// </summary>
        void Update();
    }
}
