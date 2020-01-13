using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using blog.Models;
using Markdig;

namespace blog
{
    public class DetailsModel : PageModel
    {
        private readonly blog.Data.ApplicationDbContext _context;

        public DetailsModel(blog.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Post Post { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Post = await _context.Post.FirstOrDefaultAsync(m => m.ID == id);
            var html = Markdown.ToHtml(Post.Body);
            Post.Body = html;

            if (Post == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
