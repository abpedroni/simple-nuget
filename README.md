# simple-nuget

This project contains:
- Simple Library c# project;
- Simple unit tests;
- Github workflow
  - [x] add comments of greetings on PR/Issue
  - [x] add comments by label on PR/Issue
  - [x] set pr label by branch name
  - [x] do analysis of pr title Semantic
  - [x] build pr
  - [ ] build master - **IN TESTS**
  - [ ] release master to nuget - **IN TESTS**
  - [ ] create release with tag - **WIP**

GIthub Apps installed

- [Microsoft - Teams for GitHub](https://teams.github.com/)
  - Must install bot in MS Teams;
  - commands:
    - subscribe ORG/REPO
    - subscribe ORG/REPO [pulls]
    - subscribe ORG [pulls]
    - unsubscribe ORG [issues, comments, releases, deployements]

- [Microsoft - Pull Request Quantifier](https://github.com/microsoft/PullRequestQuantifier)
  - .github/prquantifier.yaml

- [Probot - Semantic Pull Requests](https://github.com/zeke/semantic-pull-requests/blob/master/README.md)
  - .github/semantic.yml

- [Probot - Welcome](https://github.com/apps/welcome)
  - .github/config.yml

- [Probot - Request info](https://github.com/apps/request-info)
  - .github/config.yml

- [Probot - Release drafter](https://github.com/marketplace/actions/release-drafter)
  - .github/release-drafter.yml
  - release-drafter.yml
