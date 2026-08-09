# Data Model

## SiteContent

Static content that appears once on the website, such as the Hero, About and Contact sections.

| Field | Type |
|-------|------|
| Id | int |
| Key | string |
| Title | string |
| Subtitle | string? |
| Content | text |
| MediaId | int? (FK) |
| DisplayOrder | int |

---

## Projects

Projects displayed in the portfolio.

| Field | Type |
|-------|------|
| Id | int |
| Title | string |
| Slug | string |
| ShortDescription | string |
| Description | text |
| GithubUrl | string? |
| LiveUrl | string? |
| MediaId | int? (FK) |
| Featured | bool |
| DisplayOrder | int |

---

## Experience

Professional work experience.

| Field | Type |
|-------|------|
| Id | int |
| Company | string |
| Role | string |
| Description | text |
| StartDate | date |
| EndDate | date? |
| Current | bool |
| MediaId | int? (FK) |
| DisplayOrder | int |

---

## Education

Education, degrees and certifications.

| Field | Type |
|-------|------|
| Id | int |
| School | string |
| Degree | string |
| Description | text |
| StartDate | date |
| EndDate | date? |
| Current | bool |
| MediaId | int? (FK) |
| DisplayOrder | int |

---

## Skills

Technical and professional skills.

| Field | Type |
|-------|------|
| Id | int |
| Name | string |
| Category | string |
| Level | int |
| MediaId | int? (FK) |
| DisplayOrder | int |

---

## Media

Images and videos used throughout the website.

| Field | Type |
|-------|------|
| Id | int |
| FileName | string |
| FilePath | string |
| AltText | string |
| MediaType | enum (Image, Video) |

---

# Entity Relationship Diagram (ERD)

```text
                           +----------------------+
                           |        Media         |
                           +----------------------+
                           | PK Id               |
                           | FileName           |
                           | FilePath           |
                           | AltText            |
                           | MediaType          |
                           +----------+----------+
                                      ^
                                      |
                         FK MediaId   |
                                      |
      +---------------+---------------+---------------+---------------+
      |               |               |               |               |
      |               |               |               |               |
      |               |               |               |               |
+-------------+  +-------------+  +-------------+  +-------------+  +-------------+
| SiteContent |  |  Projects   |  | Experience  |  | Education   |  |   Skills    |
+-------------+  +-------------+  +-------------+  +-------------+  +-------------+
| PK Id       |  | PK Id       |  | PK Id       |  | PK Id       |  | PK Id       |
| ...         |  | ...         |  | ...         |  | ...         |  | ...         |
| FK MediaId  |  | FK MediaId  |  | FK MediaId  |  | FK MediaId  |  | FK MediaId  |
+-------------+  +-------------+  +-------------+  +-------------+  +-------------+
```

# Relationships

| Parent | Child | Cardinality |
|--------|-------|-------------|
| Media | SiteContent | 1 → 0..* |
| Media | Projects | 1 → 0..* |
| Media | Experience | 1 → 0..* |
| Media | Education | 1 → 0..* |
| Media | Skills | 1 → 0..* |

## Notes

- `SiteContent` stores one-off sections such as **Hero**, **About** and **Contact**.
- `Projects`, `Experience`, `Education` and `Skills` are collections rendered as lists.
- Every entity can optionally reference one media item through `MediaId`.
- `Media` acts as the central media library.
- If a project (or any other entity) later needs multiple images, a junction table (e.g. `ProjectMedia`) can be introduced without changing the overall design.

## Source of truth

The portfolio is fully managed through Git. The database is considered ephemeral and is recreated during deployment. Schema changes are applied through EF Core migrations and initial content is populated using seeders. Manual changes to the database are not persisted and will be overwritten on the next deployment.
