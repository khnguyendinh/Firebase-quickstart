using UnityEngine;
using System.Collections;

public class User
{
    public string id;
    public string username;
    public string email;

    public User()
    {
    }

    public User(string id, string username, string email)
    {
        this.id = id;
        this.username = username;
        this.email = email;
    }
}