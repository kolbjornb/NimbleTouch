package nimbledroidmvvm;


public abstract class PageActivity_2
	extends nimbledroidmvvm.NIActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("NimbleDroidMvvm.PageActivity`2, NimbleDroidMvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PageActivity_2.class, __md_methods);
	}


	public PageActivity_2 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PageActivity_2.class)
			mono.android.TypeManager.Activate ("NimbleDroidMvvm.PageActivity`2, NimbleDroidMvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
