#!/usr/bin/env python3

import http.server, socketserver
import aces_factory as af

PORT = 8080
Handler = http.server.SimpleHTTPRequestHandler

with socketserver.TCPServer(("", PORT), Handler) as httpd:
    print("serving at port " , PORT)
    httpd.serve_forever()

# Reply to sender with JSON containing
# new zipped file location. 