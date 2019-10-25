# graphql-example

## Example REST Queries
### Get Messages
https://localhost:44385/graphql?query={ messages{ id, name, content, replies(id: 1) { id, name, content }}}

## Example GraphQL Queries
### Get Messages
{
  messages {
    id
    name
    content
    replies(id: 1) {
      id
      name
      content
    }
  }
}

### Mutation for Message
mutation ($message: MessageInput) {
  createMessage(message: $message) { id name content }
}

{
  "message": {
     "name": "String",
  	 "content": "String"
  }
}

Returns

{
  "data": {
    "createMessage": {
      "id": 1,
      "name": "String",
      "content": "String"
    }
  }
}

### Subscription for New Messages
subscription {
  newMessages {
    id,
    name,
    content
  }
}
