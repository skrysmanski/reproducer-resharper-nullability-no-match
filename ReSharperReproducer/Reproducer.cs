//
// This file contains a reproducer for a ReSharper bug.
//

using System;

using JetBrains.Annotations;

namespace ReSharperReproducer
{
    public class Reproducer
    {
        private readonly byte[] _publicKeyBytes;

        private readonly byte[] _privateKeyBytes;

        public Reproducer(byte[] publicKeyBytes, byte[] privateKeyBytes)
        {
            this._publicKeyBytes = publicKeyBytes;
            this._privateKeyBytes = privateKeyBytes;
        }

        [MustUseReturnValue]
        public (ReadOnlyMemory<byte> publicKeyBytes, ReadOnlyMemory<byte> privateKeyBytes) ReproducerMethod()
        {
            return (this._publicKeyBytes, this._privateKeyBytes);
        }
    }
}
