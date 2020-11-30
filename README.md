# Kyameru.Component.Slack 
The Slack component sends a message to a configured slack webhook.
## To
### Setup Headers

Header | Description | Optional | Default
------ | ----------- | -------- | -------
Target | Webhook in slack | NO
MessageSource | Indicates whether the message for slack should be pulled from the body of the message OR a header. | YES | Header