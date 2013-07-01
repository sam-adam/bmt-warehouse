namespace Warehouse.Presentation.Delegates
{
    using System;
    using Warehouse.Data.Model;

    public class RentalAgreementSelectEventArgs : EventArgs
    {
        private readonly RentalAgreement _rentalAgreement;

        public RentalAgreementSelectEventArgs(RentalAgreement rentalAgreement)
        {
            _rentalAgreement = rentalAgreement;
        }

        public RentalAgreement RentalAgreement
        {
            get { return _rentalAgreement; }
        }
    }
}
