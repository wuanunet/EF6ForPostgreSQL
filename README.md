# Entity Framework 6 For PostgreSQL

## 使用組件

* 使用 **Npgsql**
* 使用 **EntityFramework6.Npgsql**


## 安裝組件

	Install-Package Npgsql

&

	Install-Package EntityFramework6.Npgsql


## 1. Code First For PostgreSQL


### Web.config

	<connectionStrings>
        <add name="SampleDbContext" connectionString="Server=localhost;Port=5432;Database=SampleDB;User Id=postgres;Password=123456;" providerName="Npgsql" />
    </connectionStrings>

&

	<entityFramework>
        <defaultConnectionFactory type="System.Data.Entity.Infrastructure.LocalDbConnectionFactory, EntityFramework">
            <parameters>
                <parameter value="mssqllocaldb" />
            </parameters>
        </defaultConnectionFactory>
        <providers>
            <provider invariantName="System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer" />
            <provider invariantName="Npgsql" type="Npgsql.NpgsqlServices, EntityFramework6.Npgsql" />
        </providers>
    </entityFramework>

&

	<system.data>
        <DbProviderFactories>
            <remove invariant="Npgsql" />
            <add name="Npgsql Data Provider" invariant="Npgsql" support="FF" description=".Net Framework Data Provider for Postgresql" type="Npgsql.NpgsqlFactory, Npgsql" />
        </DbProviderFactories>
    </system.data>


### 專案說明文：
* [Entity Framework Code First For PostgreSQL](https://dotblogs.com.tw/wuanunet/2016/02/26/entity-framework-code-first-postgresql)


## Commit Logs

#### 2016-02-25
* BTS001 - 安裝 Npgsql 與 EntityFramework6.Npgsql 組件，版本 3.0.5。
* BTS002 - WebConfig - 1.建立測試用本地DB連線。2.設定DbProviderFactories。
* BTS003 - 1.建立DbContext。2.建立Category Model。3.Enable-Migrations。

#### 2016-02-26
* BTS004 - HomeController 建立 GetCategories Action。