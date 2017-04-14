using System;
using System.Reflection;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Vns.Erp.Core.Domain
{
    /// <summary>
    /// For a discussion of this object, see 
    /// http://devlicio.us/blogs/billy_mccafferty/archive/2007/04/25/using-equals-gethashcode-effectively.aspx
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "http://SpringSample.Core.Service", IsReference = true)]
    public abstract class DomainObject<IdT>
    {
        protected IdT id = default(IdT);
        protected bool _bIsChanged;

        /// <summary>
        /// ID may be of type string, int, custom type, etc.
        /// Setter is protected to allow unit tests to set this property via reflection and to allow 
        /// domain objects more flexibility in setting this for those objects with assigned IDs.
        /// </summary>
        [DataMember]
        public virtual IdT Id {
            get { return id; }
            set { id = value; }
            //protected set { IsChanged |= !id.Equals(value); id = value; }
        }

        /// <summary>
        /// IsChanged is of type boolean.
        /// Setter is protected to allow unit tests to set this property via reflection and to allow 
        /// domain objects more flexibility in setting this for those objects with assigned properties.
        /// </summary>
        public virtual bool IsChanged
        {
            get { return _bIsChanged; }
            set { _bIsChanged = value; }
        }
        public virtual bool HasChanged
        {
            get { return IsChanged; }
            protected set { IsChanged = value; }
        }

        public override bool Equals(object obj) {
            DomainObject<IdT> compareTo = obj as DomainObject<IdT>;

            return (compareTo != null) &&
                   (HasSameNonDefaultIdAs(compareTo) ||
                    // Since the IDs aren't the same, either of them must be transient to 
                    // compare business value signatures
                    (((IsTransient()) || compareTo.IsTransient()) &&
                     HasSameBusinessSignatureAs(compareTo)));
        }

        /// <summary>
        /// Transient objects are not associated with an item already in storage.  For instance,
        /// a <see cref="Customer" /> is transient if its ID is 0.
        /// </summary>
        public virtual bool IsTransient() {
            return Id == null || Id.Equals(default(IdT));
        }

        /// <summary>
        /// Must be provided to properly compare two objects
        /// </summary>
        public abstract override int GetHashCode();

        private bool HasSameBusinessSignatureAs(DomainObject<IdT> compareTo) {
            if (compareTo == null)
            {
                throw new Exception("compareTo may not be null");
            }

            return GetHashCode().Equals(compareTo.GetHashCode());
        }

        /// <summary>
        /// Returns true if self and the provided persistent object have the same ID values 
        /// and the IDs are not of the default ID value
        /// </summary>
        private bool HasSameNonDefaultIdAs(DomainObject<IdT> compareTo) {
            if (compareTo == null)
            {
                throw new Exception("compareTo may not be null");
            }

            return (Id != null && !Id.Equals(default(IdT))) &&
                   (compareTo.Id != null && !compareTo.Id.Equals(default(IdT))) &&
                   Id.Equals(compareTo.Id);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
