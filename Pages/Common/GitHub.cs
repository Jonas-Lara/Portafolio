// #1
using Octokit;

// #2
var username = "Jonas-Lara";

// #3
var github = new GitHubClient(new ProductHeaderValue("MyAmazingApp"));
var user = await github.User.Get(username);
var repos = await github.Repository.GetAllForUser(user.Login);

// #4
foreach (var repo in repos.OrderByDescending(x => x.StargazersCount))
{
    Console.WriteLine(Environment.NewLine);
    Console.WriteLine("Name: {0}", repo.Name);
    Console.WriteLine("URL: {0}", repo.HtmlUrl);
    Console.WriteLine("Stars: {0}", repo.StargazersCount);
}
