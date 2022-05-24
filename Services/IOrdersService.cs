using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tablet_blazor.Models;

namespace tablet_blazor.Services
{
    interface IOrdersService
    {
        public Task<List<string>> GetMenus();
        public Task<List<Item>> GetItems(string menu);
        public Task SaveItem(Item item);
        public Task<List<Item>> GetTable(string table_number);
        public Task AddNote(long rid, string note);
        public Task AddQty(long rid, decimal qty);
        public Task DeleteRecord(Item item);
        public Task PrintTotal(Item item);
        public Task Printhelp(Item item);
        public Task PrintOrder(Item item);

        public Task ChangeTable(string old_table, string new_table);

    }
}
