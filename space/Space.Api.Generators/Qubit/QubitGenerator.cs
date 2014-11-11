using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Qubit
{
    public class QubitGenerator : BaseGenerator
    {
        public QubitGeneratorOptions Options { get; set; }

        public QubitModel Generate()
        {
            QubitModel model = new QubitModel();

            Int32 qbit_item_count = this.Random.Next(1, this.Options.ItemCountMax);
            Int32 qbit_item_index = 0;

            while (qbit_item_index <= (qbit_item_count - 1))
            {
                var item = new Qubit.QubitItemModel();

                item.ValueType = this.Random.Next(1, this.Options.ValueTypeMax);
                item.SizeType = this.Random.Next(1, this.Options.SizeTypeMax);
                item.Value = this.Random.Next(1, this.Options.ValueMax);
                model.Add(item);

                qbit_item_index = qbit_item_index + 1;
            }

            return model;
        }

        public QubitGenerator(Int32 SeedIdentity, QubitGeneratorOptions options)
            : base("/qubit", SeedIdentity)
        {
            this.Options = options;
        }
    }
}
