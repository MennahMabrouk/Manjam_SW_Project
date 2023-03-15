import requests
from bs4 import BeautifulSoup

# Specify the URL of the website to scrape
url = "https://eg.usembassy.gov/education-culture/exchange-opportunities/allexchanges/"

# Send a request to the website and retrieve the HTML
html = requests.get(url).text

# Parse the HTML using BeautifulSoup
soup = BeautifulSoup(html, 'html.parser')

# define a p list to store all of them
paragraph = []

# Find the first paragraph containing the desired word
for p in soup.find_all("p"):
    if "internship" in p.text or "event" in p.text or "scholarship" in p.text or "exchange program" in p.text or "scholarships" in p.text:
        paragraph.append(p.text)


# Print the paragraphs
print(paragraph[0])
print(paragraph[1])
print(paragraph[2])
