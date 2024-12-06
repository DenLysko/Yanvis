using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Yanvis.Domain;
using Yanvis.Mvc.MyControllers;
using Yanvis.Domain.Tables;

namespace Yanvis.Mvc.Controllers;

public class JSONEditorController : BaseController
{
    private YanvisContext _context;

    public JSONEditorController(YanvisContext context)
    {
        _context = context;
    }
    [HttpPost]
    public IActionResult SaveJson([FromBody] JsonElement json)
    {
        //string jsonString = JsonSerializer.Serialize(json);

        var record = new JsonRecord()
        {
            LastUpdateDate = DateTime.Now.ToUniversalTime(),
            JsonRecordContent = json,
            CreationDate = DateTime.Now.ToUniversalTime()
        };

        // Логика обработки JSON
        _context.JsonRecords.Add(record);
        _context.SaveChanges();

        // Например, сохранение в файл
        //System.IO.File.WriteAllText("path/to/file.json", jsonString);

        return Ok(new { message = "JSON успешно сохранён!" });
    }

}
