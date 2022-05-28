from flask import Flask,render_template,request
from PythonData import DownloadPath
app = Flask(__name__)
@app.route('/Result', methods=['POST'])
def Result():
    id = ""
    try:
        id = request.form['ID']
        resultpath = DownloadPath(id)
        return ("JSON path:"+ resultpath)
    except:
        return ("Some Error Occured")
if __name__ == '__main__':
    app.run(host='0.0.0.0',debug=False)

