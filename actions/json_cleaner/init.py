import json
from json_minify import json_minify

with open('./src/Web/Grand.Web/App_Data/appsettings.json', 'r') as jsonfile:
    jsondata = json_minify(jsonfile.read(), strip_space = True)
    data = json.loads(jsondata)

f = open("./src/Web/Grand.Web/App_Data/appsettings.json", "w")
json.dump(data, f, indent=4)
f.close()
