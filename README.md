# Kyameru.Component.Slack

![Build](https://github.com/djsuperchief/Kyameru.Component.Slack/workflows/Build%20And%20Test/badge.svg)
![CodeQL](https://github.com/djsuperchief/Kyameru.Component.Slack/workflows/CodeQL/badge.svg)
[![Coverage Status](https://coveralls.io/repos/github/djsuperchief/Kyameru.Component.Slack/badge.svg?branch=main)](https://coveralls.io/github/djsuperchief/Kyameru.Component.Slack?branch=main)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Kyameru.Component.Slack)

The Slack component sends a message to a configured slack webhook.
## To
### Setup Headers

Header | Description | Optional | Default
------ | ----------- | -------- | -------
Target | Webhook in slack | NO
MessageSource | Indicates whether the message for slack should be pulled from the body of the message OR a header. | YES | Header

## More Info
For more information see Kyameru Core documentation. (https://github.com/djsuperchief/Kyameru)