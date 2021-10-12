# FFS

Map Maslow's Hierarchy of Needs to a Heirarchical Task Network

## High Level

- Unity3D
  - Attempt Entity Component System approach
- MongoDB
  - Redis cache layer
- Admin CMS
  - Design/implement schema for Needs/HTN

## Tasks

- Set up Project
  - ~~Unity~~
    - ~~TODO: Push to Git~~
    - TODO: Think of an asset control mechanism for large files
      - `git lfs` has banned itself for being a fucked thing
  - ~~Admin CMS~~
    - https://github.com/JerkyTreats/fss-admin
    - ~~Setup `strapi` headless CMS in `fss-admin` repo~~
    - TODO: Consider pulling admin into this `FSS` project
    - ~~TODO: Push to Git~~
  - ~~Mongo~~
    - ~~Setup Atlas~~
    - TODO: Docker image for local development
      - On init create from Atlas backup?
  - Redis
    - Create docker object for Redis
    - Setup `docker up` flow
- Connections
  - ~~Connect Admin CMS to Mongo~~
  - Connect Unity to Mongo
    - Setup Dotnet project and create DB access lib
    - Setup DLL build into Unity project
    - Setup Unity Script to use DB lib
  - Connect Unity to Redis
    - Create/Extend DB DLL to use Redis else call Mongo
    - Use `protobuf`
    - Implement data cache in Unity
- Serialization
  - Figure out deserialization into Unity structs
  - Implement Needs de/serialization

## HTN

Hierarchical Task Network (HTN) is an extension of Goal Oriented Action Planning (GOAP). Where GOAP has the actor choosing from a list of simple tasks, HTN has complex tasks that are essentially an array of tasks.

Look into `strategy` pattern to see if it can be useful for the HTN engine.

Use `ShipPrototype` for some idea on personal implementation of GOAP.

- How to map a HTN engine into ECS
- How to assign actors HTN
- Serialize/save actor needs/statuses
