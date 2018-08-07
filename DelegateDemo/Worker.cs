using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            var mediaInventory = new MediaInventory();
            var recordPlayer = new RecordPlayer();
            var casettePlayer = new CasettePlayer();

            MediaInventory.TestMedia testRecordDelegate =
                new MediaInventory.TestMedia(recordPlayer.PlayRecord);
            MediaInventory.TestMedia TestCassetteDelegate =
                new MediaInventory.TestMedia(casettePlayer.TestCassette);

            mediaInventory.TestResult(testRecordDelegate);
            mediaInventory.TestResult(TestCassetteDelegate);
        }
    }
}
