namespace Warehouse.Data.Model
{
    using System;
    using System.Collections.Generic;

    public class RentalReceipt
    {
        private readonly IList<RentalReceiptDetail> _details;

        public virtual string Id { get; set; }
        public virtual RentalAgreement RentalAgreement { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime ReceiptDate { get; set; }
        public virtual string Reference { get; set; }
        public virtual Employee CreatedBy { get; set; }
        public virtual IList<RentalReceiptDetail> Details { get; set; }

        public RentalReceipt(){}

        public RentalReceipt(IList<RentalReceiptDetail> details)
        {
            _details = details;
        }
    }
}
