namespace kusmeeks.info.mvc.Controllers
{
    public class InfoController : Controller
    {
        public InfoController() { }

        [Route("/")]
        [Route("/Animus")]
        public IActionResult Animus() { return this.View(); }

        [Route("/Corpus")]
        public IActionResult Corpus() { return this.View(); }

        [Route("/Notes")]
        public IActionResult Notes()  { return this.View(); }

        [Route("/Watch")]
        public IActionResult Watch()  { return this.View(); }

        [Route("/Give")]
        public IActionResult Give()   { return this.View(); }
    }
}