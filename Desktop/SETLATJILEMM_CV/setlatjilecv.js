
  const btnGithub = document.getElementById("btnGithub")
  async function getResponse(){
  const url = "https://api.github.com/search/users?q=MSetlatjile"
  const response = await fetch(url)
  const result = await response.json()

  result.items.forEach(i=>{
  github.href = i.html_url

  })
}
